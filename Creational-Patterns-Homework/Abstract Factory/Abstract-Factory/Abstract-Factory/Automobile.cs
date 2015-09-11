using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstract_Factory
{
    public abstract class Automobile
    {

        public abstract int MaxSpeed { get; }

        public virtual string Name 
        { 
            get
            {
                return this.GetType().Name;    
            }

            
        }
        
            
        
    }
}
