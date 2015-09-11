using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class PaperbackItem
    {
        private readonly string type;
        private readonly Dictionary<string, string> characteristics = new Dictionary<string, string>();

        public PaperbackItem(string type)
        {
            this.type = type;
        }

        public string this[string key]
        {
            get { return this.characteristics[key]; }
            set { this.characteristics[key] = value; }
        }

        public bool Coloured { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine(this.type + ":");
            foreach (var ch in this.characteristics)
            {
                Console.WriteLine(string.Format("{0} : {1}", ch.Key, ch.Value));
            }
            Console.WriteLine("Coloured : {0}", this.Coloured.ToString());
            Console.WriteLine();
        }
    }
}
