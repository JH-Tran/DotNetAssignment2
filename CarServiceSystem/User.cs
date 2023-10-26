namespace CarServiceSystem
{
    public abstract class User
    {
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public string Email { get; protected set; }
        public string Password { get; protected set; }
        protected User(string FirstName, string LastName, string Email, string Password)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Password = Password;
        }
        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
