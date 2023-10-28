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
            var showCustForm = new showCustomers();
            showCustForm.Show();
        }

        private void showMechTTButton_Click(object sender, EventArgs e)
        {

        }

        private void showMechanicsButton_Click(object sender, EventArgs e)
        {
            var showMechForm = new showMechanics();
            showMechForm.Show();
        }

        private void viewCarHistButton_Click(object sender, EventArgs e)
        {

        }
    }
}
