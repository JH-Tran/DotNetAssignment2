namespace CarServiceSystem
{
    public class Mechanic : User
    {
        private string workShopName;
        public int MechanicId { get; set; }
        public string WorkShopName
        {
            get { return workShopName; } set { workShopName = value; }
        }
        
        public Mechanic(string FirstName, string LastName, string Email, string Password, string WorkShopName) : base(FirstName, LastName, Email, Password)
        {
            this.firstName = FirstName;
            this.lastName = LastName;
            this.email = Email;
            this.password = Password;
            this.workShopName = WorkShopName;
        }
        public Mechanic() { }

    }
}
