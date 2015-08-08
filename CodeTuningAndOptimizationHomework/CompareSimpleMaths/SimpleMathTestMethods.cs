/* Task 2. Compare simple Maths

    Write a program to compare the performance of:
        add, subtract, increment, multiply, divide
    for the values:
        int, long, float, double and decimal
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace CompareMathMethods
{
    public static class SimpleMathTestMethods
    {
        public static void TestSimpleMathMethods(string methodName, long testScope)
        {
            methodName = methodName.ToLower();
            Dictionary<string, double> reports = new Dictionary<string, double>();
            var stopWatch = new Stopwatch();

            long longTester = 1L;
            stopWatch.Start();
            ExecuteMethod(methodName, longTester, testScope);
            stopWatch.Stop();
            double result = stopWatch.Elapsed.TotalMilliseconds;
            reports.Add("Long", result);
            stopWatch.Reset();

            int intTester = 1;
            stopWatch.Start();
            ExecuteMethod(methodName, intTester, testScope);
            stopWatch.Stop();
            result = stopWatch.Elapsed.TotalMilliseconds;
            reports.Add("Int", result);
            stopWatch.Reset();

            float floatTester = 1F;
            stopWatch.Start();
            ExecuteMethod(methodName, floatTester, testScope);
            stopWatch.Stop();
            result = stopWatch.Elapsed.TotalMilliseconds;
            reports.Add("Float", result);
            stopWatch.Reset();

            double doubleTester = 1D;
            stopWatch.Start();
            ExecuteMethod(methodName, doubleTester, testScope);
            stopWatch.Stop();
            result = stopWatch.Elapsed.TotalMilliseconds;
            reports.Add("Double", result);
            stopWatch.Reset();

            decimal decimalTester = 1M;
            stopWatch.Start();
            ExecuteMethod(methodName, decimalTester, testScope);
            stopWatch.Stop();
            result = stopWatch.Elapsed.TotalMilliseconds;
            reports.Add("Decimal", result);
            stopWatch.Reset();

            PrintResults(methodName, reports);
        }

        private static void ExecuteMethod(string methodName, dynamic digit, long numberIterations)
        {
            dynamic index = 0;
            if (digit.GetType() == typeof(System.Int32))
            {
                index = Convert.ToInt32(index);
            }
            else if (digit.GetType() == typeof(System.Int64))
            {
                index = Convert.ToInt64(index);
            }
            else if (digit.GetType() == typeof(System.Single))
            {
                index = Convert.ToSingle(index);
            }
            else if (digit.GetType() == typeof(System.Double))
            {
                index = Convert.ToDouble(index);
            }
            else if (digit.GetType() == typeof(System.Decimal))
            {
                index = Convert.ToDecimal(index);
            }
            else
            {
                throw new ArgumentException("Inproper data variable - must be a number!");
            }

            for (index = 1; index <= numberIterations; index++)
            {
                try
                {
                    switch (methodName)
                    {
                        case "add": digit += index; break;
                        case "subtract": digit -= index; break;
                        case "increment": digit++;  break;
                        case "multiply": digit *= index; break;
                        case "divide": digit /= index; break;
                        default: throw new InvalidOperationException("Unrecognized method!");
                    }
                }
                catch(OverflowException)
                {
                    digit = Math.Abs(digit - digit) + 1;
                }
            }
        }

        public static void PrintResults(string methodName, Dictionary<string, double> reports)
        {
            Console.WriteLine("Results for {0} method in milliseconds:", methodName);
            var results = reports.OrderByDescending(x => x.Value);
            int index = 1;
            foreach (var res in results)
            {
                Console.WriteLine("{0}.{1} - {2}", index++, res.Key, res.Value);
            }
            Console.WriteLine();
        }
    }
}
