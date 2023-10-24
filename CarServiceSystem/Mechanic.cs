namespace CarServiceSystem
{
    public class Mechanic : User
    {
        protected String WorkShopName;
        public Mechanic(string FirstName, string LastName, string Email, string Password) : base(FirstName, LastName, Email, Password)
        {
        }
    }
}
