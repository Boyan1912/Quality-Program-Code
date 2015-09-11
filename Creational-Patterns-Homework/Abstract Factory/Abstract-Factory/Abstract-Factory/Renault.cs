using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstract_Factory
{
   
    public class Renault : Bus
    {
        private int maxSeats = 6;
        

        public override int MaxSpeed
        {
            get
            {
                return this.maxSeats;
            }

        }
        
    }
}
