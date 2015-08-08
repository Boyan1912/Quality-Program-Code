using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareMathMethods
{

    // NOT READY!!!

    public static class SortAlgorithmsTests
    {
        private const int COLLECTIONS_SIZE = 100;
        
        private static int[] GenerateRandomnIntArray()
        {
            var rnd = new Random();
            var intArray = new int[COLLECTIONS_SIZE];

            for (int i = 0; i < COLLECTIONS_SIZE; i++)
            {
                intArray[i] = rnd.Next();
            }
            return intArray;
        }

        private static double[] GenerateRandomnDoubleArray()
        {
            var rnd = new Random();
            var doubleArray = new double[COLLECTIONS_SIZE];

            for (int i = 0; i < COLLECTIONS_SIZE; i++)
            {
                doubleArray[i] = (double)rnd.Next();
            }
            return doubleArray;
        }

        private static string[] GenerateRandomnStringArray()
        {
            var rnd = new Random();
            var stringArray = new string[COLLECTIONS_SIZE];

            for (int i = 0; i < COLLECTIONS_SIZE; i++)
            {
                int wordLength = rnd.Next(10);
                var randomnSymbols = new StringBuilder();
                for (int j = 0; j < wordLength; j++)
                {
                    randomnSymbols.Append((char)rnd.Next(65, 123));
                }
                stringArray[i] = randomnSymbols.ToString();
            }
            return stringArray;
        }
    }
}
