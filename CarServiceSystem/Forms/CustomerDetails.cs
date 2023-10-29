namespace CarServiceSystem.Forms
{
    public partial class CustomerDetails : UserControl
    {
        Customer loginCustomer;
        public CustomerDetails()
        {
            InitializeComponent();
        }

        public void AutoFillCustomerDetails(Customer loginCustomer)
        {
            this.loginCustomer = loginCustomer;
            emailLabel.Text = $"Email: {loginCustomer.Email}";
            firstNameTextBox.Text = loginCustomer.FirstName;
            lastNameTextBox.Text = loginCustomer.LastName;
        }
        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            using (MechanicServiceContext context = new MechanicServiceContext())
            {
                var result = context.Customers.SingleOrDefault(customerContext => customerContext.Email == loginCustomer.Email);
                if (result != null)
                {
                    result.FirstName = firstNameTextBox.Text;
                    result.LastName = lastNameTextBox.Text;
                    context.SaveChanges();
                }
            }
        }
        public String GetAllTextBoxString()
        {
            return $"{firstNameTextBox.Text} {lastNameTextBox.Text}";
        }
    }
}
