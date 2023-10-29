namespace CarServiceSystem.Forms
{
    public partial class CustomerDetails : UserControl
    {
        Customer loginCustomer;
        public CustomerDetails()
        {
            InitializeComponent();
        }
        //Refreshes the interface information with the class provided.
        public void UpdateCustomerDetailInterface(Customer loginCustomer)
        {
            this.loginCustomer = loginCustomer;
            emailLabel.Text = $"Email: {loginCustomer.Email}";
            firstNameTextBox.Text = loginCustomer.FirstName;
            lastNameTextBox.Text = loginCustomer.LastName;
        }
        //Confirms the change of the user's name change in the database.
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
        //Returns the text box string (user's firt and last name)
        public String GetAllTextBoxString()
        {
            return $"{firstNameTextBox.Text} {lastNameTextBox.Text}";
        }
    }
}
