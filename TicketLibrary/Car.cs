using System;
using System.Collections.Generic;
using System.Text;

namespace TicketLibrary
{
   public class Car : Vehicle
    {
        
        public DateTime Date;
        public double Price()
        {
            double price = 240;
            return price;

        }
        public string VehicleType()
        {
            string vehicletype = "Car";
            return vehicletype;

        }
      
        

        


    }
}
