/*Task 3. Compare advanced Maths

    Write a program to compare the performance of:
        square root, natural logarithm, sinus
    for the values:
        float, double and decimal
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

namespace CompareMathMethods
{
    public static class AdvancedMathTestMethods
    {

        public static void TestAdvancedMathMethods(long testScope)
        {
            var squareRootResults = new Dictionary<string, double>();
            var naturalLogaritmResults = new Dictionary<string, double>();
            var sinusResults = new Dictionary<string, double>();

            var randomnDigit = new Random();
            var testDigit = randomnDigit.Next();

            float floatTester = (float)testDigit;
            double doubleTester = (double)testDigit;
            decimal decimalTester = (decimal)testDigit;

            var digitTypes = new dynamic[3] { floatTester, doubleTester, decimalTester };

            for (int i = 0; i < digitTypes.Length; i++)
            {
                var stopWatch = new Stopwatch();
                double result = 0;
                Type digitType = digitTypes[i].GetType();
                bool digitIsDecimal = digitType == typeof(System.Decimal);
                var methodTester = digitTypes[i];

                stopWatch.Start();
                for (int j = 0; j < testScope; j++)
                {
                    if (digitIsDecimal)
                    {
                        methodTester = (decimal)Math.Sqrt((double)digitTypes[i]);
                    }
                    else
                    {
                        methodTester = Math.Sqrt(digitTypes[i]);
                    }
                }
                stopWatch.Stop();
                result = stopWatch.Elapsed.TotalMilliseconds;
                squareRootResults.Add(digitType.ToString(), result);
                stopWatch.Reset();

                stopWatch.Start();
                for (int j = 0; j < testScope; j++)
                {
                    if (digitIsDecimal)
                    {
                        methodTester = (decimal)Math.Log((double)digitTypes[i]);
                    }
                    else
                    {
                        methodTester = Math.Log(digitTypes[i]);
                    }
                }
                stopWatch.Stop();
                result = stopWatch.Elapsed.TotalMilliseconds;
                naturalLogaritmResults.Add(digitType.ToString(), result);
                stopWatch.Reset();

                stopWatch.Start();
                for (int j = 0; j < testScope; j++)
                {
                    if (digitIsDecimal)
                    {
                        methodTester = (decimal)Math.Sin((double)digitTypes[i]);
                    }
                    else
                    {
                        methodTester = Math.Sin(digitTypes[i]);
                    }
                }
                stopWatch.Stop();
                result = stopWatch.Elapsed.TotalMilliseconds;
                sinusResults.Add(digitType.ToString(), result);
                stopWatch.Reset();
            }
            SimpleMathTestMethods.PrintResults("Square root", squareRootResults);
            SimpleMathTestMethods.PrintResults("Natural logarithm", naturalLogaritmResults);
            SimpleMathTestMethods.PrintResults("Sinus", sinusResults);
        }
    }
}
