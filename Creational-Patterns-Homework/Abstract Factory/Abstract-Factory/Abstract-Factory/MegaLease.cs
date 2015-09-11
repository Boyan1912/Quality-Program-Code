using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public class MegaLease : LeaseCompany
    {

        public override Automobile GetCar()
        {
            return new Seat();
        }

        public override Automobile GetBus()
        {
            return new Peugeot();
        }
    }
}
