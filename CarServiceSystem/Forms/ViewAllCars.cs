using Microsoft.EntityFrameworkCore;
using System.Globalization;
using System.Windows.Forms;

namespace CarServiceSystem.Forms
{
    public partial class ViewAllCars : UserControl
    {
        Customer loggedInCustomer;
        Car selectedCar;
        public ViewAllCars()
        {
            InitializeComponent();
        }
        private void ViewAllCarsInterfaceLoad(object sender, EventArgs e)
        {
            //Loads the combo box for what mechanic is avaliable to select from
            mechanicComboBox.Items.Clear();
            using (var context = new MechanicServiceContext())
            {
                var mechanicList = context.Mechanics
                    .ToList();
                foreach (var mechanic in mechanicList)
                {
                    mechanicComboBox.Items.Add(mechanic.Email);
                }
            }
            //Loads the combo box for what time is avaliable to book for mechanic in a 30 minute interval from 8AM to 6PM
            timeComboBox.Items.Clear();
            DateTime time = DateTime.Today.AddHours(8);
            DateTime endTime = DateTime.Today.AddHours(18);
            while (time <= endTime)
            {
                timeComboBox.Items.Add(time.ToString("hh:mm tt"));
                time = time.AddMinutes(30);
            }
        }
        //Updates the interface details for the specific chosen car.
        private void UpdateSelectedCarInterface(Car car)
        {
            selectedCar = car;
            carNameLabel.Text = car.GetName();
            carNameLabel.ForeColor = Color.Black;
            UpdateServiceLog(car);
            EmailTextBoxSecondaryOwner.Text = "";
            if (selectedCar.SecondaryOwner != null)
            {
                CurrentSecondaryOwnerLabel.Text = $"Current Secondary Owner: {selectedCar.SecondaryOwner.Email}";
            }
            else
            {
                CurrentSecondaryOwnerLabel.Text = $"Current Secondary Owner: NONE";
            }
        }
        //Updates the list of cars to what the current login customer own.
        //The list comprise of buttons with the car's information (model, year, licence number and whether they are the owner or secondary owner)
        //The button is assigned it's event that will update the interface with the selected car's information
        public void UpdateCustomerCars(Customer cusomter)
        {
            loggedInCustomer = cusomter;
            using (var context = new MechanicServiceContext())
            {
                carListFlowLayout.Controls.Clear();
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
                        ownerButton.BackColor = Color.White;
                        ownerButton.Text = $"{carOwned.Make}\r\n{carOwned.Model}\r\n{carOwned.Year}\r\n{carOwned.LicenceNumber}\r\n [Owner]";
                        ownerButton.Tag = carOwned;
                        ownerButton.Click += EventCarDetailsClicked;
                        carListFlowLayout.Controls.Add(ownerButton);
                    }
                }
                var ownSecondaryCarsList = context.Cars
                     .Where(carOwn => carOwn.SecondaryOwner == cusomter)
                     .ToList();
                if (ownSecondaryCarsList != null)
                {
                    foreach (var carOwned in ownSecondaryCarsList)
                    {
                        Button ownerButton = new Button();
                        ownerButton.Size = new Size(165, 122);
                        ownerButton.TabIndex = 14;
                        ownerButton.BackColor = Color.White;
                        ownerButton.Text = $"{carOwned.Make}\r\n{carOwned.Model}\r\n{carOwned.Year}\r\n{carOwned.LicenceNumber}\r\n [Secondary Owner]";
                        ownerButton.Tag = carOwned;
                        ownerButton.Click += EventCarDetailsClicked;
                        carListFlowLayout.Controls.Add(ownerButton);
                    }
                }
            }
        }
        //The created buttons are assigned a car class that will be loaded in the interface.
        private void EventCarDetailsClicked(object sender, EventArgs e)
        {
            Button carClickedButton = (Button)sender;
            Car? car = carClickedButton.Tag as Car;
            if (car != null)
            {
                UpdateSelectedCarInterface(car);
            }
        }
        //Update the service log history of the specific car.
        //Refreshes when the user changes interface to update any new data.
        //Display the service startDateTime and endDateTime of service, full name of the mechanic, odometer when it was service and description of the service performed
        public void UpdateServiceLog(Car car)
        {
            carHistoryTableLayout.Controls.Clear();
            carHistoryTableLayout.RowCount = 1;

            using (var context = new MechanicServiceContext())
            {
                var carServiceLogList = context.ServiceLogs
                    .Include(carOwn => carOwn.Mechanic)
                    .Include(carOwn => carOwn.Car)
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
                        //Insert values of labels into the cell of the table row
                        carHistoryTableLayout.Controls.Add(startDateTime, 0, carHistoryTableLayout.RowCount - 1);
                        carHistoryTableLayout.Controls.Add(endDateTime, 1, carHistoryTableLayout.RowCount - 1);
                        carHistoryTableLayout.Controls.Add(mechanicName, 2, carHistoryTableLayout.RowCount - 1);
                        carHistoryTableLayout.Controls.Add(carOdometer, 3, carHistoryTableLayout.RowCount - 1);
                        carHistoryTableLayout.Controls.Add(taskPerformed, 4, carHistoryTableLayout.RowCount - 1);
                        count++;
                        //Create a new row in table
                        carHistoryTableLayout.RowCount++;
                        carHistoryTableLayout.RowStyles.Add(new RowStyle());
                    }
                }
            }
        }
        //Change the combo box of the customer choosing the booking time to 12 interval.
        private void TimePickerSelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTime = timeComboBox.SelectedItem.ToString();
            DateTime time = DateTime.ParseExact(selectedTime, "hh:mm tt", CultureInfo.InvariantCulture);
            dateTimePicker1.Value = time;
        }
        //Confirms the booking of the current login user with the specific mechanic and car.
        //The booking includes the date and time of when it was selected.
        //Error handles occurs if any information is null or incorrect.
        private void ConfirmBookingClick(object sender, EventArgs e)
        {
            try
            {
                using (MechanicServiceContext context = new MechanicServiceContext())
                {
                    DateTime dateTimeBooking = dateTimePicker1.Value.Date + ConvertTimeTo24Hours(timeComboBox.SelectedItem.ToString());
                    var chosenMech = context.Mechanics
                        .Where(m => m.Email == mechanicComboBox.SelectedItem)
                        .FirstOrDefault();
                    var customer = context.Customers
                        .Where(c => c.Email == loggedInCustomer.Email)
                        .FirstOrDefault();
                    var car = context.Cars
                        .Where(selectedCar => selectedCar.VehicleIdentificationNumber == selectedCar.VehicleIdentificationNumber)
                        .FirstOrDefault();
                    Booking newBooking = new Booking() { Customer = customer, Mechanic = chosenMech, Car = car, dateTime = dateTimeBooking };
                    context.Bookings.Add(newBooking);
                    context.SaveChanges();
                    bookingErrorLabel.ForeColor = Color.Black;
                    bookingErrorLabel.Text = "Booking has been created";
                    bookingErrorLabel.Visible = true;
                }
            }
            catch
            {
                bookingErrorLabel.ForeColor = Color.Red;
                bookingErrorLabel.Text = "Invalid Information to Book";
                bookingErrorLabel.Visible = true;
            }
        }
        //Updates the car secondary owner to another person to share its service log history.
        private void AddSecondaryOwners(object sender, EventArgs e)
        {
            try
            {
                using (MechanicServiceContext context = new MechanicServiceContext())
                {
                    var secondaryOwner = context.Customers
                        .Where(c => c.Email == EmailTextBoxSecondaryOwner.Text)
                        .FirstOrDefault();
                    if (secondaryOwner != null)
                    {
                        var carChosen = context.Cars.SingleOrDefault(carsContext => carsContext.VehicleIdentificationNumber == selectedCar.VehicleIdentificationNumber);
                        carChosen.SecondaryOwner = secondaryOwner;
                        context.SaveChanges();
                        SecondaryOwnerError.Visible = false;
                        CurrentSecondaryOwnerLabel.Text = $"Current Secondary Owner: {secondaryOwner.Email}";
                    }
                    else
                    {
                        SecondaryOwnerError.Visible = true;
                    }
                }
            }
            catch
            {
                SecondaryOwnerError.Visible = true;
            }
        }
        //Changes the time format from 12 hours to 24 hours.
        private TimeSpan ConvertTimeTo24Hours(string time)
        {
            DateTime dateTime = DateTime.Parse(time);

            if (dateTime.ToString("tt", CultureInfo.InvariantCulture).ToLower() == "pm")
            {
                dateTime = dateTime.AddHours(12);
            }
            Console.WriteLine(dateTime.TimeOfDay);
            return dateTime.TimeOfDay;
        }

    }
}
