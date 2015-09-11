using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstract_Factory
{
    public class Mercedes : Car
    {
        private int maxSpeed = 240;
        

        public override int MaxSpeed
        {
            get
            {
                return this.maxSpeed;
            }

        }

        
    }
}
