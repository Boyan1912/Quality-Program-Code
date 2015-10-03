using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class FlightMediator
    {

        private Engine engine;

        private Aviation aviation;

        private Wheels wheels;

        private Cockpit cockpit;

        public FlightMediator(Engine engine, Aviation aviation, Wheels wheels, Cockpit cockpit)
        {

            this.engine = engine;

            this.aviation = aviation;

            this.wheels = wheels;

            this.cockpit = cockpit;

        }

        public bool IsReady()
        {

            return this.engine.IsReady() && this.aviation.IsReady() && this.wheels.IsReady() && this.cockpit.IsReady();

        }

    }

    public class Engine
    {

        public void Start()
        {

        }

        public bool IsReady()
        {

            return true;

        }

    }

    public class Aviation
    {

        private int fuelLevel = 1000;

        public bool IsReady()
        {

            return this.fuelLevel > 5000; // Returns false as not enough fuel

        }

    }

    public class Wheels
    {

        public bool IsReady()
        {

            return true;

        }

    }

    public class Cockpit
    {

        public bool IsReady()
        {

            return true;

        }

    } 
}
