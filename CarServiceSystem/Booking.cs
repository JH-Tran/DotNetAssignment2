using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceSystem
{
    public class Booking
    {
        public int id;
        public Customer customer;
        public Mechanic mechanic;
        public Car car;
        protected bool bookingStatus = false;
        public DateTime DateTime { get; protected set; }
        public bool BookingStatus 
        {
            get { return BookingStatus; }
            set { BookingStatus = value; }
        }
        //Create booking with the required information with customer and mechanic.
        public Booking(Customer customer, Mechanic mechanic, Car car, DateTime dateTime)
        {
            this.customer = customer;
            this.mechanic = mechanic;
            this.car = car;
            this.DateTime = dateTime;
        }
        public Booking()
        {

        }
        public String GetBookingDetailsFormat()
        {
            //NOT FINISHED
            return $"Date and Time:";
        }
    }
}