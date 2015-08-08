using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareMathMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleMathTestMethods.TestSimpleMathMethods("add", 900);
            SimpleMathTestMethods.TestSimpleMathMethods("subtract", 900);
            SimpleMathTestMethods.TestSimpleMathMethods("increment", 900);
            SimpleMathTestMethods.TestSimpleMathMethods("Multiply", 900);
            SimpleMathTestMethods.TestSimpleMathMethods("divide", 900);

            AdvancedMathTestMethods.TestAdvancedMathMethods(1500);
        }
    }
}
