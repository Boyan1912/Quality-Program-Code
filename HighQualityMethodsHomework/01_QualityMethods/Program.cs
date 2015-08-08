
/*
 * Task 1. Quality Methods

    Take the VS solution Methods and refactor its code to follow the guidelines of high-quality methods.
    Ensure:
        you handle errors correctly
            when the methods cannot do what their name says, throw an exception (do not return wrong result).
        good cohesion and coupling
        good naming
        no side effects, etc.


 using System;

namespace Methods
{
    class Methods
    {
        static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                Console.Error.WriteLine("Sides should be positive.");
                return -1;
            }
            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }

        static string NumberToDigit(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
            }

            return "Invalid number!";
        }

        static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                return -1;
            }

            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > elements[0])
                {
                    elements[0] = elements[i];
                }
            }
            return elements[0];
        }

        static void PrintAsNumber(object number, string format)
        {
            if (format == "f")
            {
                Console.WriteLine("{0:f2}", number);
            }
            if (format == "%")
            {
                Console.WriteLine("{0:p0}", number);
            }
            if (format == "r")
            {
                Console.WriteLine("{0,8}", number);
            }
        }


        static double CalcDistance(double x1, double y1, double x2, double y2, 
            out bool isHorizontal, out bool isVertical)
        {
            isHorizontal = (y1 == y2);
            isVertical = (x1 == x2);

            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }

        static void Main()
        {
            Console.WriteLine(CalcTriangleArea(3, 4, 5));
            
            Console.WriteLine(NumberToDigit(5));
            
            Console.WriteLine(FindMax(5, -1, 3, 2, 14, 2, 3));
            
            PrintAsNumber(1.3, "f");
            PrintAsNumber(0.75, "%");
            PrintAsNumber(2.30, "r");

            bool horizontal, vertical;
            Console.WriteLine(CalcDistance(3, -1, 3, 2.5, out horizontal, out vertical));
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);

            Student peter = new Student() { FirstName = "Peter", LastName = "Ivanov" };
            peter.OtherInfo = "From Sofia, born at 17.03.1992";

            Student stella = new Student() { FirstName = "Stella", LastName = "Markova" };
            stella.OtherInfo = "From Vidin, gamer, high results, born at 03.11.1993";

            Console.WriteLine("{0} older than {1} -> {2}",
                peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}

*/
using System;

namespace Methods
{
    class CalculationMethods
    {   
        private static void ValidateExistingParameter(params object[] parameters)
        {
            foreach (var param in parameters)
            {
                if (param == null)
                {
                    throw new ArgumentNullException();
                }
            }
        }

        private static void ValidateLine(double line)
        {
            ValidateExistingParameter(line);
            
            bool isPositiveValue = 0 <= line;
            bool isInRange = line < double.MaxValue;

            if (!isPositiveValue)
            {
                throw new ArgumentOutOfRangeException(string.Format("{0} must be greater than zero", line));
            }
            else if (!isInRange)
            {
                throw new OverflowException(string.Format("{0} must be within range for a double value: < {1}", line, double.MaxValue));
            }
        }

        private static bool CanFormTriangle(double sideA, double sideB, double sideC)
        {
            ValidateLine(sideA);
            ValidateLine(sideB);
            ValidateLine(sideC);

            return (sideA + sideB > sideC) && (sideA + sideC > sideB) && (sideB + sideC > sideA);
        }

        static double CalcTriangleArea(double sideA, double sideB, double sideC)
        {
            if (CanFormTriangle(sideA, sideB, sideC))
            {
                double semiPerimeter = (sideA + sideB + sideC) / 2;
                double area = Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));
                return area;
            }
            else
            {
                throw new ArgumentException(string.Format("The values {0}, {1} and (2) do not correspond to a valid triangle", sideA, sideB, sideC));
            }
        }

        static string NumberToDigit(int number)
        {
            ValidateExistingParameter(number);

            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
            }

            throw new ArgumentOutOfRangeException("Value must be in the range of 0 - 9");
        }

        static int FindMax(params int[] elements)
        {
            ValidateExistingParameter(elements);

            if (elements.Length < 1)
            {
                throw new ArgumentException("Invalid array argument. Array must contain elements");
            }

            int max = int.MinValue;
            for (int i = 1; i < elements.Length; i++)
            {
                if (max < elements[i])
                {
                    max = elements[i];
                }
            }
            return max;
        }

        static void PrintAsNumber(double number, string format)
        {
            ValidateExistingParameter(number, format);

            switch (format)
            {
                case "f": Console.WriteLine("{0:f2}", number); break;
                case "%": Console.WriteLine("{0:p0}", number); break;
                case "r": Console.WriteLine("{0,8}", number); break;
                default: throw new ArgumentException(string.Format("{0} is invalid format argument", format));
            }
        }

        static double CalcDistance(double x1, double y1, double x2, double y2,
            out bool isHorizontal, out bool isVertical)
        {
            ValidateExistingParameter(x1, y1, x2, y2);   

            isHorizontal = (y1 == y2);
            isVertical = (x1 == x2);

            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }

        static void Main()
        {
            
            Console.WriteLine(CalcTriangleArea(3, 4, 5));

            Console.WriteLine(NumberToDigit(5));

            Console.WriteLine(FindMax(5, -1, 3, 2, 14, 2, 3));

            PrintAsNumber(1.3, "f");
            PrintAsNumber(0.75, "%");
            PrintAsNumber(2.30, "r");

            bool horizontal, vertical;
            Console.WriteLine(CalcDistance(3, -1, 3, 2.5, out horizontal, out vertical));
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);
            /*
            Student peter = new Student() { FirstName = "Peter", LastName = "Ivanov" };
            peter.OtherInfo = "From Sofia, born at 17.03.1992";

            Student stella = new Student() { FirstName = "Stella", LastName = "Markova" };
            stella.OtherInfo = "From Vidin, gamer, high results, born at 03.11.1993";

            Console.WriteLine("{0} older than {1} -> {2}",
                peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));*/
        }
    }
}
