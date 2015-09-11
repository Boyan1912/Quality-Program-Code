using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Contrast : ISetting
    {
        private int contrastValue;
        private const int MAX_VALUE = 100;
        private const int DEFAULT_VALUE = 50;

        public Contrast()
        {
            this.contrastValue = DEFAULT_VALUE;
        }

        public int ContrastValue
        {
            get
            {
                return this.contrastValue;
            }
            set
            {
                this.contrastValue = value;
            }
        }


        public void Set(int value)
        {
            this.contrastValue = value;
            if (this.contrastValue > MAX_VALUE)
            {
                this.contrastValue = MAX_VALUE;
            }
        }
    }
}
