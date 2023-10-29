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
        public Mechanic loggedInMechanic = null!;
        public MechanicDetails()
        {
            InitializeComponent();
        }

        private void SaveChangesBtn_Click(object sender, EventArgs e)
        {
            string firstName = FirstNameInput.Text.Trim();
            string lastName = LastNameInput.Text.Trim();

            if (firstName == string.Empty || lastName == string.Empty)
            {
                InvalidInputLbl.Show();
            }
            else
            {
                InvalidInputLbl.Hide();
                try
                {
                    using (MechanicServiceContext context = new MechanicServiceContext())
                    {
                        var mechanic = context.Mechanics.First(m => m.MechanicId == loggedInMechanic.MechanicId);
                        mechanic.FirstName = firstName;
                        mechanic.LastName = lastName;
                        context.SaveChanges();
                        this.loggedInMechanic = mechanic;
                        MessageBox.Show("Details Updated");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating details");
                    Console.WriteLine("Error updating mechanic" + ex);
                }
            }


        }
    }
}
