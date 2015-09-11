using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstract_Factory
{
    public class Car : Automobile
    {
        private int maxSpeed;

        public Car()
        {
            this.maxSpeed = 250;
        }

        public override int MaxSpeed
        {
            get
            {
                return this.maxSpeed;
            }
            
        }
        public override string Name
        {
            get { return this.GetType().Name; }
        }

    }
}
