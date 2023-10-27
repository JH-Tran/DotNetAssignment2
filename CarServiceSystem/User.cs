namespace CarServiceSystem
{
    public abstract class User
    {
        protected int id;
        protected string firstName = "";
        protected string lastName = "";
        protected string email = "";
        protected string password = "";
        public int ID { get { return id; } set { id = value; } }
        public string FirstName { get { return firstName; } set{ firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Password { get { return password; } set { password = value; } }
        public User(string firstName, string lastName, string email, string password)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.password = password;
        }
        public User()
        {

        }
        public string GetFullName()
        {
            return $"{firstName} {lastName}";
        }
    }
}
