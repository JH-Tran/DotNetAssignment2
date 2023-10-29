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
            if (!EmailManager.IsValidEmail(EmailInput.Text))
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
                    var customer = context.Customers
                        .FirstOrDefault(c => c.Email == inputEmail && c.Password == inputPassword);

                    if (customer != null)
                    {
                        this.Hide();
                        CustomerMainMenu customerMainMenu = new CustomerMainMenu();
                        customerMainMenu.Show();
                    }
                    else
                    {
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
                                Console.WriteLine("No user found in all 3 tables");
                            }
                        }
                    }
                }
            }
        }
    }
}