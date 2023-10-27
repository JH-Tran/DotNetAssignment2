namespace CarServiceSystem
{
    public abstract class User
    {
        public int userID;
        protected string firstName;
        protected string lastName;
        protected string email;
        protected string password;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
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
