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
    public partial class LookupCar : UserControl
    {
        public LookupCar()
        {
            InitializeComponent();
        }

        private void SearchLicenceBtn_Click(object sender, EventArgs e)
        {

            var returnedCar = MechanicMainMenu.cars.FirstOrDefault(car => car.LicenceNumber == LicenceNumberInput.Text);

            if (returnedCar != null)
            {
                CarNotFoundLbl.Hide();
                MakeAndModelLbl.Text = "Make/Model: " + returnedCar.Make + " " + returnedCar.Model;
                YearLbl.Text = "Year: " + returnedCar.Year;
                OdometerLbl.Text = "Odometer: " + returnedCar.Odometer;
                CarDetailsPnl.Show();
                ServiceHistoryPnl.Show();
            }
            else
            {
                CarDetailsPnl.Hide();
                ServiceHistoryPnl.Hide();
                CarNotFoundLbl.Show();
            }



        }
    }
}
