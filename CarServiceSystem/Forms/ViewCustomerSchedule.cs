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
    public partial class ViewCustomerSchedule : UserControl
    {
        public ViewCustomerSchedule()
        {
            InitializeComponent();
        }

        private void ViewCustomerSchedule_Load(object sender, EventArgs e)
        {
            CreateCustomerScheduleRows();
            tableLayoutPanel1.RowCount = tableLayoutPanel1.RowCount + 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Controls.Add(new Label() { Text = "Information" }, 1, tableLayoutPanel1.RowCount - 1);
        }
        Booking[] CustomerSchedule;
        private void CreateCustomerScheduleRows()
        {
            foreach (Booking Schedule in CustomerSchedule)
            {
                tableLayoutPanel1.RowCount = tableLayoutPanel1.RowCount + 1;
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
                tableLayoutPanel1.Controls.Add(new Label() { Text = "Information" }, 1, tableLayoutPanel1.RowCount - 1);
            }
        }
    }
}
