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
    public partial class ServiceAdminMainMenu : Form
    {
        public ServiceAdminMainMenu()
        {
            InitializeComponent();
        }

        private void ServiceAdminMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void showCustomersButton_Click(object sender, EventArgs e)
        {
            var custForm = new showCustomers();
            custForm.Show();
            this.Hide();
        }

        private void showMechanicsButton_Click(object sender, EventArgs e)
        {
            var mechForm = new showMechanics();
            mechForm.Show();
            this.Hide();
        }

        private void showCarsButton_Click(object sender, EventArgs e)
        {
            var showCarsForm = new showCars();
            showCarsForm.Show();
            this.Hide();
        }

        private void ServiceAdminMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
