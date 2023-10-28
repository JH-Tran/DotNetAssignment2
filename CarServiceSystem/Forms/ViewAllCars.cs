namespace CarServiceSystem.Forms
{
    public partial class ViewAllCars : UserControl
    {
        public ViewAllCars()
        {
            InitializeComponent();
        }
        public void AutoFillCustomerCars(Customer cusomter)
        {
            using (var context = new MechanicServiceContext())
            {
                var ownCarsList = context.Cars
                    .Where(carOwn => carOwn.Owner == cusomter)
                    .ToList();
                if (ownCarsList != null)
                {
                    foreach (var element in ownCarsList)
                    {

                    }
                }
                var ownSecondaryCarsList = context.Cars
                     .Where(carOwn => carOwn.SecondaryOwner == cusomter)
                     .ToList();
                if (ownCarsList != null)
                {
                    foreach (var element in ownCarsList)
                    {

                    }
                }
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
