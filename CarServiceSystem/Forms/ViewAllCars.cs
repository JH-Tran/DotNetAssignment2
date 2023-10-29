using System.Windows.Forms;

namespace CarServiceSystem.Forms
{
    public partial class ViewAllCars : UserControl
    {
        public ViewAllCars()
        {
            InitializeComponent();
        }
        public void UpdateCarDetails(Car car)
        {
            carNameLabel.Text = $"{car.Make}\r\n{car.Model}\r\n{car.Year}";

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
                    foreach (var carOwned in ownCarsList)
                    {
                        Button ownerButton = new Button();
                        ownerButton.Size = new Size(165, 122);
                        ownerButton.TabIndex = 14;
                        ownerButton.Text = $"{carOwned.Make}\r\n{carOwned.Model}\r\n{carOwned.Year}\r\n{carOwned.LicenceNumber}\r\n [Owner]";
                        ownerButton.Tag = carOwned;
                        ownerButton.Click += EventCarDetailsClicked;
                        carListFlowLayout.Controls.Add(ownerButton);
                    }
                }
                var ownSecondaryCarsList = context.Cars
                     .Where(carOwn => carOwn.SecondaryOwner == cusomter)
                     .ToList();
                if (ownCarsList != null)
                {
                    foreach (var carOwned in ownCarsList)
                    {
                        Button ownerButton = new Button();
                        ownerButton.Size = new Size(165, 122);
                        ownerButton.TabIndex = 14;
                        ownerButton.Text = $"{carOwned.Make}\r\n{carOwned.Model}\r\n{carOwned.Year}\r\n{carOwned.LicenceNumber}\r\n [Secondary Owner]";
                        ownerButton.Tag = carOwned;
                        ownerButton.Click += EventCarDetailsClicked;
                        carListFlowLayout.Controls.Add(ownerButton);
                    }
                }
            }
        }
        public void AutoFillServiceLog(Car car)
        {
            using (var context = new MechanicServiceContext())
            {
                var carServiceLogList = context.ServiceLogs
                    .Where(carOwn => carOwn.Car == car)
                    .ToList();
                if (carServiceLogList != null)
                {
                    int count = 0;
                    foreach (var element in carServiceLogList)
                    {
                        //Create column values
                        Label startDateTime = new Label();
                        startDateTime.Name = $"serviceStartLabel{count}";
                        startDateTime.Text = element.StartDateTime.ToString();
                        Label endDateTime = new Label();
                        endDateTime.Name = $"serviceEndLabel{count}";
                        endDateTime.Text = element.EndDateTime.ToString();
                        Label mechanicName = new Label();
                        mechanicName.Name = $"serviceMechanicName{count}";
                        mechanicName.Text = element.Mechanic.GetFullName();
                        Label carOdometer = new Label();
                        carOdometer.Name = $"serviceCarOdometer{count}";
                        carOdometer.Text = element.CarOdometer.ToString() + "km";
                        Label taskPerformed = new Label();
                        taskPerformed.Name = $"servicePerformed{count}";
                        taskPerformed.Text = element.Task;
                        //Create a new row in table
                        carHistoryTableLayout.RowCount++;
                        carHistoryTableLayout.RowStyles.Add(new RowStyle());
                        //Insert values of labels into the cell of the table row
                        carHistoryTableLayout.Controls.Add(startDateTime, 0, carHistoryTableLayout.RowCount - 1);
                        carHistoryTableLayout.Controls.Add(endDateTime, 1, carHistoryTableLayout.RowCount - 1);
                        carHistoryTableLayout.Controls.Add(mechanicName, 2, carHistoryTableLayout.RowCount - 1);
                        carHistoryTableLayout.Controls.Add(carOdometer, 3, carHistoryTableLayout.RowCount - 1);
                        carHistoryTableLayout.Controls.Add(taskPerformed, 4, carHistoryTableLayout.RowCount - 1);
                        count++;
                    }
                }
            }
        }
        private void EventCarDetailsClicked(object sender, EventArgs e)
        {
            Button carClickedButton = (Button)sender;
            Car? car = carClickedButton.Tag as Car;
            if (car != null)
            {

                AutoFillServiceLog(car);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
