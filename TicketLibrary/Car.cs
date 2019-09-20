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
           
           

            double price = 240;
            
            if (Date.DayOfWeek==DayOfWeek.Saturday || Date.DayOfWeek == DayOfWeek.Sunday)
            {
                price -= price * 20 / 100;

            }

            if (brobizz)
            {
                price=price * 0.95;
            }
            // else
            //{
            //  return 240;
            //}
            return price;
           
            

        }
        public string VehicleType()
        {
            string vehicletype = "Car";
            return vehicletype;

        }
        

       
        
      
        

        


    }
}
