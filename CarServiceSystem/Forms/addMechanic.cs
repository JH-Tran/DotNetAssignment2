using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace CarServiceSystem.Forms
{
    public partial class addMechanic : Form
    {
        public addMechanic()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            var adminMainMenuForm = new ServiceAdminMainMenu();
            adminMainMenuForm.Show();
            this.Hide();
        }

        private void fNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void lNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void workshopTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var context = new MechanicServiceContext();
            context.Database.EnsureCreated();


            string message = "Are you sure you want to create this Mechanic?";
            string caption = "Add Mechanic";

            var confirmation = MessageBox.Show(message, caption,
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);

            if (confirmation == DialogResult.Yes)
            {
                // Checks if any of the fields are empty, and if they are, an error window pops up
                if (fNameTxt.Text == "" || lNameTxt.Text == "" || workshopTxt.Text == "" || emailTxt.Text == "" || passwordTxt.Text == "")
                {
                    MessageBox.Show("One or more fields are invalid", "Invalid");
                }
                else if (EmailManager.IsValidEmail(emailTxt.Text))
                {
                    Mechanic mechanic = new Mechanic(fNameTxt.Text, lNameTxt.Text, emailTxt.Text, passwordTxt.Text, workshopTxt.Text);
                    context.Mechanics.Add(mechanic);
                    context.SaveChanges();
                    var showMechForm = new showMechanics();
                    showMechForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Email", "Invalid Email");
                }
            }
        }
    }
}
