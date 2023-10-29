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

                    if (serviceHistory.Count == 0)
                    {
                        NoServiceHistoryLbl.Text = "No Service History Found for Car with License Number: " + returnedCar.LicenceNumber;
                        ServiceHistoryGridView.Hide();
                        NoServiceHistoryLbl.Show();
                    }
                    else
                    {
                        foreach (ServiceLog log in serviceHistory)
                        {
                            ServiceHistoryGridView.Rows.Add(log.Car.Owner.GetFullName(), log.Mechanic.GetFullName(),
                                                             log.Task, log.CarOdometer, log.CompletionDateTime.ToShortDateString());
                        }
                        NoServiceHistoryLbl.Hide();
                        ServiceHistoryGridView.Show();
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
