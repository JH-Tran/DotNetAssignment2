namespace CarServiceSystem
{
    public class Mechanic : User
    {
        public string WorkShopName { get; set; }
        


        public Mechanic(string FirstName, string LastName, string Email, string Password) : base(FirstName, LastName, Email, Password)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Password = Password;
        }


    }
}
