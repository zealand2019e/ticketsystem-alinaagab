using System;
using System.Collections.Generic;
using System.Text;

namespace TicketLibrary
{
    public abstract class Vehicle
    {
        private string licensePlate;
        public DateTime Date;


        public string LicensePlate
        {
            get
            {
                return licensePlate;
            }

            set
            {
                if( value.Length > 7)
                {
                    throw new Exception("License plate cannot be longer than 7 characters!");
                }
                else
                {
                    licensePlate = value;
                }
            }
        }
        
    }
}
