using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public class Client
    {
        private LeaseCompany company;

        public Client(string name, LeaseCompany company)
        {
            this.Name = name;
            this.company = company;
        }

        public string Name { get; set; }


        public Automobile Auto { get; set; }

        public void LeaseCar()
        {
            this.Auto = this.company.GetCar();
            Console.WriteLine(string.Format("{0} leased a {1}", this.Name, this.Auto.Name));
        }

        public void LeaseBus()
        {
            this.Auto = this.company.GetBus();
            Console.WriteLine(string.Format("{0} leased a {1}", this.Name, this.Auto.Name));
        }

        public void Goto(string place)
        {
            if (this.Auto == null)
            {
                Console.WriteLine(string.Format("{0} has not leased an automobile", this.Name));
                return;
            }

            Console.WriteLine(string.Format("{0} is driving {1} with {2} km/h going to {3}", this.Name, this.Auto.Name, this.Auto.MaxSpeed, place));
        }
    }
}
