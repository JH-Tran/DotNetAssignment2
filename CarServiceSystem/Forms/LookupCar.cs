using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

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
            using (MechanicServiceContext context = new MechanicServiceContext())
            {
                var returnedCar = context.Cars
                    .Include(c => c.Owner)
                    .Include(c => c.ServiceHistory)
                    .Where(c => c.LicenceNumber == LicenceNumberInput.Text)
                    .FirstOrDefault() ?? null!;
                if (returnedCar != null)
                {
                    CarNotFoundLbl.Hide();
                    MakeAndModelLbl.Text = "Make/Model: " + returnedCar.Make + " " + returnedCar.Model;
                    YearLbl.Text = "Year: " + returnedCar.Year;
                    OdometerLbl.Text = "Odometer: " + returnedCar.Odometer;
                    CarDetailsPnl.Show();

                    var serviceHistory = context.ServiceLogs
                        .Include(s => s.Car)
                        .ThenInclude(c => c.Owner)
                        .Include(s => s.Mechanic)
                        .Where(s => s.Car.LicenceNumber == returnedCar.LicenceNumber)
                        .ToList();


                    foreach (ServiceLog log in serviceHistory)
                    {
                        //The following should get the customername directly from the log rather then the car (could be second owner)
                        //currently serviceLog is not storing Customer in database. when a set method is given to customer in log
                        //it links log and customer but throws an error due to database not knowing what to do incase of delete.
                        //not sure how to fix
                        ServiceHistoryGridView.Rows.Add(log.Car.Owner.GetFullName(), log.Mechanic.GetFullName(),
                                                         log.Task, log.CarOdometer, log.CompletionDateTime.ToShortDateString());
                    }

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
}
