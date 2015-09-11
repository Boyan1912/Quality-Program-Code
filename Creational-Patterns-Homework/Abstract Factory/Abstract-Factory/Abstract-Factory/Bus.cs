using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstract_Factory
{
    public class Bus : Automobile
    {
        private int maxSeats;
        
        public override int MaxSpeed
        {
            get { return this.MaxSpeed; }
        }

        public int MaxSeats
        {
            get
            {
                return this.maxSeats;
            }

        }
        
    }
}
