using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var pesho = new Client("Pesho", new Hertz());
            var gosho = new Client("Gosho", new MegaLease());

            pesho.LeaseCar();
            pesho.Goto("Varna");

            gosho.LeaseCar();
            gosho.Goto("Pernik");

            var misho = new Client("Misho", new MegaLease());
            misho.Goto("Burgas");
            misho.LeaseBus();
        }
    }
}
