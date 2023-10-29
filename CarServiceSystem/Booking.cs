using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceSystem
{
    public class Booking
    {
        private int bookingId;
        private Customer? customer;
        private Mechanic mechanic;
        private Car car;
        protected bool bookingStatus = false;
        public DateTime dateTime { get; set; }
        public bool BookingStatus 
        {
            get { return BookingStatus; }
            set { BookingStatus = value; }
        }
        public int BookingId 
        { 
            get { return bookingId; }  
            set { bookingId = value; } 
        }
        public Customer? Customer
        {
            get { return customer; }
            set { customer = value; }
        }
        public Mechanic Mechanic
        {
            get { return mechanic; }
            set { mechanic = value; }
        }
        public Car Car
        {
            get { return car; }
            set { car = value; }
        }
        //Create booking with the required information with customer and mechanic.
        public Booking(Customer customer, Mechanic mechanic, Car car, DateTime dateTime)
        {
            this.customer = customer;
            this.mechanic = mechanic;
            this.car = car;
            this.dateTime = dateTime;
        }
        public Booking()
        {

        }
    }
}