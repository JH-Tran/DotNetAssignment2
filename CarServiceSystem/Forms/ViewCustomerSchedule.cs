using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarServiceSystem.Forms
{
    public partial class ViewCustomerSchedule : UserControl
    {
        public ViewCustomerSchedule()
        {
            InitializeComponent();
        }

        public void LoadCustomerSchedule(Customer customer)
        {
            using (MechanicServiceContext context = new MechanicServiceContext())
            {
                var bookingList = context.Bookings
                    .Include(carOwn => carOwn.Car)
                    .Where(carOwn => carOwn.Customer == customer && !carOwn.BookingStatus)
                    .ToList();
                if (bookingList != null)
                {
                    foreach (var booking in bookingList)
                    {
                        tableLayoutPanel1.RowCount = tableLayoutPanel1.RowCount + 1;
                        string aboutSchedule = $"Date and Time: {booking.dateTime}\r\nCar Model: {booking.Car.Make} {booking.Car.Model} {booking.Car.Year} \r\nLicence Plate: {booking.Car.LicenceNumber}\r\n";
                        Label scheduleLabel = new Label();
                        scheduleLabel.Text = aboutSchedule;
                        scheduleLabel.AutoSize = true;
                        tableLayoutPanel1.Controls.Add(scheduleLabel, 1, tableLayoutPanel1.RowCount - 1);
                    }
                }
            }
        }
    }
}
