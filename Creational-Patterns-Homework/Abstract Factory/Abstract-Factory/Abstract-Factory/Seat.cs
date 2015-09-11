using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public class Seat : Car
    {
        private int maxSpeed = 180;
       
        public override int MaxSpeed
        {
            get
            {
                return this.maxSpeed;
            }

        }
       
    }
}
