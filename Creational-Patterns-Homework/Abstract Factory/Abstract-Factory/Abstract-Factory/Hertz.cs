using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public class Hertz : LeaseCompany
    {



        public override Automobile GetCar()
        {
            return new Mercedes();
        }

        public override Automobile GetBus()
        {
            return new Renault();
        }
    }
}
