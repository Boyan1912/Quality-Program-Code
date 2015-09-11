using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public abstract class LeaseCompany
    {
        public virtual Automobile GetCar()
        {
            return new Car();
        }

        public virtual Automobile GetBus()
        {
            return new Bus();
        }
    }
}
