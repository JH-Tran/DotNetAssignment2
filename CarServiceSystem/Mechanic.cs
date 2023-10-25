namespace CarServiceSystem
{
    public class Mechanic : User
    {
        protected string workShopName;
        


        public Mechanic(string FirstName, string LastName, string Email, string Password) : base(FirstName, LastName, Email, Password)
        {
        }


    }
}
