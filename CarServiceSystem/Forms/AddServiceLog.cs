using Microsoft.EntityFrameworkCore;
using System.Data;


namespace CarServiceSystem.Forms
{
    public partial class AddServiceLog : UserControl
    {
        public Mechanic loggedInMechanic = null!;
        private Car currentlyDisplayedCar = null!;
        private ServiceLog currentLog = null!;

        public AddServiceLog()
        {
            InitializeComponent();
        }

        private void SearchLicenceBtn_Click(object sender, EventArgs e)
        {
            //Try retrieve the car from database using input license number
            using (MechanicServiceContext context = new MechanicServiceContext())
            {
                currentlyDisplayedCar = context.Cars
                    .Include(c => c.Owner)
                    .Where(c => c.LicenceNumber == LicenceNumberInput.Text)
                    .FirstOrDefault() ?? null!;
            }
            //If a car was successfuly retrieved display its information aswell as the "add service log" panel
            if (currentlyDisplayedCar != null)
            {
                CarNotFoundLbl.Hide();
                MakeAndModelLbl.Text = "Make/Model: " + currentlyDisplayedCar.Make + " " + currentlyDisplayedCar.Model;
                YearLbl.Text = "Year: " + currentlyDisplayedCar.Year;
                OdometerLbl.Text = "Odometer: " + currentlyDisplayedCar.Odometer;
                CarDetails.Show();

                CustomerComboBox.Items.Clear();
                CustomerComboBox.Items.Add(currentlyDisplayedCar.Owner);
                CustomerComboBox.DisplayMember = "FirstName";
                CustomerComboBox.ValueMember = "FirstName";
                if (currentlyDisplayedCar.SecondaryOwner != null)
                {
                    CustomerComboBox.Items.Add(currentlyDisplayedCar.SecondaryOwner);
                }

                AddServiceLogPnl.Show();
            }
            else
            {
                currentlyDisplayedCar = null!;
                CarDetails.Hide();
                AddServiceLogPnl.Hide();
                CarNotFoundLbl.Show();
            }
        }

        private void AddLogBtn_Click(object sender, EventArgs e)
        {
            if (currentlyDisplayedCar != null)
            {
                //check for valid inputs before creating the service log
                if (int.TryParse(OdometerInput.Text, out int newOdometer) && CustomerComboBox.SelectedItem is Customer customer)
                {
                    InvalidInputLbl.Hide();

                    //Updates the Odometer Label on the form with new odometer reading
                    var parts = OdometerLbl.Text.Split(":");
                    parts[1] = OdometerInput.Text;
                    OdometerLbl.Text = string.Join(":", parts);

                    //create new log based on given input
                    ServiceLog newLog = new ServiceLog(customer, loggedInMechanic, currentlyDisplayedCar, TaskInput.Text, newOdometer);
                    //add new log to db and update cars odometer
                    using (MechanicServiceContext context = new MechanicServiceContext())
                    {
                        var car = context.Cars.First(car => car.CarId == currentlyDisplayedCar.CarId);
                        car.ServiceHistory.Add(newLog);
                        car.Odometer = newOdometer;
                        context.SaveChanges();
                        currentLog = newLog;
                    }
                    MechanicNameLbl.Text = "Mechanic: " + loggedInMechanic.GetFullName();
                    ServiceDescriptionTxtBox.Text = "The following has been completed on " + customer.GetFullName() + "'s " + currentlyDisplayedCar.GetName() + ": " + Environment.NewLine + Environment.NewLine + TaskInput.Text;
                    InvoicePnl.Show();
                }
                else
                {
                    InvalidInputLbl.Show();
                }
            }
        }

        private void SendInvoiceBtn_Click(object sender, EventArgs e)
        {
            //ensures the inputed cost is a valid number (cost is rounded to 2 decimal places)
            if (decimal.TryParse(InputCost.Text, out decimal cost))
            {

                InvalidCostLbl.Hide();
                EmailManager.SendInvoice(currentLog, decimal.Round(cost, 2));
                InvoicePnl.Hide();
                CarDetails.Hide();
                ResetAddLogFields();
                AddServiceLogPnl.Hide();
                InputCost.Text = string.Empty;
            }

            else
            {
                InvalidCostLbl.Show();
            }
        }

        private void ResetAddLogFields()
        {
            OdometerInput.Text = string.Empty;
            CustomerComboBox.SelectedIndex = -1;
            TaskInput.Text = string.Empty;
        }
    }
}
