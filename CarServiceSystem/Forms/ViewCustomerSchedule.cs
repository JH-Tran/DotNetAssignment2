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
                    .Where(carOwn => carOwn.Customer == customer && !carOwn.BookingStatus)
                    .ToList();
                if (bookingList != null)
                {
                    foreach (var booking in bookingList)
                    {
                        tableLayoutPanel1.RowCount = tableLayoutPanel1.RowCount + 1;
                        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
                        string label = $"Date and Time: {booking.dateTime}\r\nCar Model: {booking.Car.GetName()} \r\nLicence Plate: {booking.Car.LicenceNumber}\r\n";
                        tableLayoutPanel1.Controls.Add(new Label() { Text = "Information" }, 1, tableLayoutPanel1.RowCount - 1);
                    }
                }
            }
        }
    }
}
