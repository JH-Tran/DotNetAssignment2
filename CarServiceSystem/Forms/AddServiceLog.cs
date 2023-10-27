using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarServiceSystem.Forms
{
    public partial class AddServiceLog : UserControl
    {
        Car? currentCar;
        Mechanic mechanic = MechanicMainMenu.mechanic;
        ServiceLog log;
        public AddServiceLog()
        {
            InitializeComponent();
        }

        private void SearchLicenceBtn_Click(object sender, EventArgs e)
        {
            currentCar = MechanicMainMenu.cars.FirstOrDefault(car => car.LicenceNumber == LicenceNumberInput.Text); //replace with proper call to db
            Customer customer = new("Secondary", "Test", "...", "123");
            currentCar.SecondaryOwner = customer;
            // NEEDED FUNCTION TO REPLACE SOME LOGIC BELOW get a list of owners (Customer) given a car (only needed if theres going to be more then 2 owners otherwise maybe swap the combobox to something else
            if (currentCar != null)
            {
                CarNotFoundLbl.Hide();
                MakeAndModelLbl.Text = "Make/Model: " + currentCar.Make + " " + currentCar.Model;
                YearLbl.Text = "Year: " + currentCar.Year;
                OdometerLbl.Text = "Odometer: " + currentCar.Odometer;
                CarDetails.Show();

                CustomerComboBox.Items.Clear();
                CustomerComboBox.Items.Add(currentCar.Owner);
                CustomerComboBox.DisplayMember = "FirstName";
                CustomerComboBox.ValueMember = "FirstName";
                if (currentCar.SecondaryOwner != null)
                {
                    CustomerComboBox.Items.Add(currentCar.SecondaryOwner);
                }

                AddServiceLogPnl.Show();
            }
            else
            {
                currentCar = null;
                CarDetails.Hide();
                AddServiceLogPnl.Hide();
                CarNotFoundLbl.Show();
            }
        }

        private void AddLogBtn_Click(object sender, EventArgs e)
        {

            if (currentCar != null)
            {
                if (int.TryParse(OdometerInput.Text, out int newOdometer) && CustomerComboBox.SelectedItem is Customer customer)
                {
                    InvalidInputLbl.Hide();

                    //Updates the Odometer Label on the form with new odometer reading
                    var parts = OdometerLbl.Text.Split(":");
                    parts[1] = OdometerInput.Text;
                    OdometerLbl.Text = string.Join(":", parts);




                    log = new ServiceLog(customer, mechanic, currentCar, TaskInput.Text, newOdometer);

                    //call function to add log to cars service history
                    MechanicNameLbl.Text = "Mechanic: " + mechanic.GetFullName();
                    ServiceDescriptionTxtBox.Text = "The following has been completed on " + customer.GetFullName() + "'s " + currentCar.GetName() + ": " + Environment.NewLine + Environment.NewLine + TaskInput.Text;
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
            if (int.TryParse(InputCost.Text, out int cost))
            {
                EmailManager.SendInvoice(log, cost);
                InvoicePnl.Hide();
                CarDetails.Hide();
                ResetAddLogFields();
                AddServiceLogPnl.Hide();
            }

            else
            {
                //display error message
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
