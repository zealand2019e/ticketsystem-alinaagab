using System;
using System.Collections.Generic;
using System.Text;

namespace TicketLibrary
{
    public class MC : Vehicle
    {
        private string LicensePlate;
        public DateTime date;
        string message = " ";
        

        public double Price()
        {
            double price = 125;
            return price;
        }
        public string Vehicle()
        {
            string vehicle = "MC";
            return vehicle;
        }
        

    }
    
}
