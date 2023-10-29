using CarServiceSystem.Forms;

namespace CarServiceSystem
{
    public partial class LoginMenu : Form
    {
        public LoginMenu()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (!EmailManager.IsValidEmail(EmailInput.Text) || PasswordInput.Text == string.Empty)
            {
                InvalidUserPassLbl.Show();
            }
            else
            {
                InvalidUserPassLbl.Hide();
                string inputEmail = EmailInput.Text;
                string inputPassword = PasswordInput.Text;

                using (MechanicServiceContext context = new MechanicServiceContext())
                {
                    //First check if the user exists in customer table
                    var customer = context.Customers
                        .FirstOrDefault(c => c.Email == inputEmail && c.Password == inputPassword);

                    if (customer != null)
                    {
                        this.Hide();
                        CustomerMainMenu customerMainMenu = new CustomerMainMenu(customer);
                        customerMainMenu.Show();
                    }
                    else
                    {
                        //If not in the customer table check mechanic table
                        var mechanic = context.Mechanics
                            .FirstOrDefault(m => m.Email == inputEmail && m.Password == inputPassword);
                        if (mechanic != null)
                        {
                            this.Hide();
                            MechanicMainMenu mechanicMainMenu = new MechanicMainMenu(mechanic);
                            mechanicMainMenu.Show();
                        }
                        else
                        {
                            //otherwise check the admin table
                            var serviceAdmin = context.ServiceAdmins
                                .FirstOrDefault(s => s.Email == inputEmail && s.Password == inputPassword);

                            if (serviceAdmin != null)
                            {
                                this.Hide();
                                ServiceAdminMainMenu serviceAdminMainMenu = new ServiceAdminMainMenu();
                                serviceAdminMainMenu.Show();
                            }
                            else
                            {
                                InvalidUserPassLbl.Show();
                            }
                        }
                    }
                }
            }
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            CustomerRegistration customerRegistration = new CustomerRegistration();
            customerRegistration.ShowDialog();
        }
    }
}