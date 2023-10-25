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
    public partial class MechanicDetails : UserControl
    {
        public MechanicDetails()
        {
            InitializeComponent();
        }

        private void SaveChangesBtn_Click(object sender, EventArgs e)
        {
            string firstName = FirstNameInput.Text;
            string lastName = LastNameInput.Text;
            string email = EmailInput.Text;

            //update db

            MechanicMainMenu.mechanic.FirstName = firstName;
            MechanicMainMenu.mechanic.LastName = lastName;
            MechanicMainMenu.mechanic.Email = email;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FirstNameInput.Text = MechanicMainMenu.mechanic.FirstName;
            LastNameInput.Text = MechanicMainMenu.mechanic.LastName;
            EmailInput.Text = MechanicMainMenu.mechanic.Email;
        }
    }
}
