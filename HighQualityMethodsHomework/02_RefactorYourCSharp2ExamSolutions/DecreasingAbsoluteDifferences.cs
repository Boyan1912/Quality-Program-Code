

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DecreasingAbsoluteDifferences
{
    static void Main(string[] args)
    {
        int T = 0;

        try
        {
            T = int.Parse(Console.ReadLine());
        }
        catch(FormatException)
        {
            Console.WriteLine("Invalid input, cannot parse to int!");
        }

        string[][] lines = new string[T][];

        for (int i = 0; i < T; i++)
        {
            lines[i] = Console.ReadLine().Split(' ');
        }

        StringBuilder results = new StringBuilder();

        foreach (string[] array in lines)
        {
            int[] sequence = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                sequence[i] = int.Parse(array[i]);
            }

            bool[] isDecreasingSequence = new bool[sequence.Length];

            for (int i = 0; i < isDecreasingSequence.Length; i++)
            {
                isDecreasingSequence[i] = true;
            }

            int start = sequence[0];
            int absoluteDifference = 0;
            int absoluteDifferenceStart = 0;

            for (int i = 1; i < sequence.Length; i++)
            {
                if (start > sequence[i])
                {
                    absoluteDifferenceStart = start - sequence[i];
                }
                else
                {
                    absoluteDifferenceStart = sequence[i] - start;
                }

                if (i > 1 && absoluteDifference - absoluteDifferenceStart != 1 && absoluteDifference - absoluteDifferenceStart != 0)
                {
                    isDecreasingSequence[i] = false;
                    results.Append(isDecreasingSequence[i] + "\n");
                    break;
                }

                if (i == sequence.Length - 1)
                {
                    results.Append(isDecreasingSequence[i] + "\n");
                }

                start = sequence[i];
                absoluteDifference = absoluteDifferenceStart;
            }
        }
        Console.WriteLine(results.ToString().Trim());
    }
}
