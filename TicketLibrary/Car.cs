using System;
using System.Collections.Generic;
using System.Text;

namespace TicketLibrary
{
   public class Car : Vehicle
    {
        
        public DateTime Date;
        public bool brobizz;

        public  double Price()
        {
            if (brobizz)
            {
                return 240 * 0.95;
            }
            else
            {
                return 240;
            }
            

        }
        public string VehicleType()
        {
            string vehicletype = "Car";
            return vehicletype;

        }

        
      
        

        


    }
}
