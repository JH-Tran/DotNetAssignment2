using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.Logging;
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
        public Mechanic loggedInMechanic = null!;
        private Car currentlyDisplayedCar = null!;
        private ServiceLog currentLog = null!;

        public AddServiceLog()
        {
            InitializeComponent();
        }

        private void SearchLicenceBtn_Click(object sender, EventArgs e)
        {
            using(MechanicServiceContext context = new MechanicServiceContext())
            {
                currentlyDisplayedCar = context.Cars
                    .Include(c => c.Owner)
                    .Where(c => c.LicenceNumber == LicenceNumberInput.Text)
                    .First();
            }


            // NEEDED FUNCTION TO REPLACE SOME LOGIC BELOW get a list of owners (Customer) given a car (only needed if theres going to be more then 2 owners otherwise maybe swap the combobox to something else
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
                if (int.TryParse(OdometerInput.Text, out int newOdometer) && CustomerComboBox.SelectedItem is Customer customer)
                {
                    InvalidInputLbl.Hide();

                    //Updates the Odometer Label on the form with new odometer reading
                    var parts = OdometerLbl.Text.Split(":");
                    parts[1] = OdometerInput.Text;
                    OdometerLbl.Text = string.Join(":", parts);




                    currentLog = new ServiceLog(customer, loggedInMechanic, currentlyDisplayedCar, TaskInput.Text, newOdometer);

                    //call function to add log to cars service history
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
            if (int.TryParse(InputCost.Text, out int cost))
            {
                EmailManager.SendInvoice(currentLog, cost);
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
