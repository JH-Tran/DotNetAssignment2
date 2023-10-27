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
    public partial class CustomerDetails : UserControl
    {
        public CustomerDetails()
        {
            InitializeComponent();
        }

        public void AutoFillCustomerDetails(Customer CustomerSignIn)
        {
            FirstNameTextBox.Text = CustomerSignIn.FirstName;
            LastNameTextBox.Text = CustomerSignIn.LastName;
            EmailTextBox.Text = CustomerSignIn.Email;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {

        }
    }
}
