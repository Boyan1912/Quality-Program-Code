
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class EnigmaCat
{
    static void Main(string[] args)
    {
        string[] inputSeventeenNumeral = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

        BigInteger decimalNumber = 0;
        string twentySixNumber = "";
        StringBuilder result = new StringBuilder();

        foreach (string number in inputSeventeenNumeral)
        {
            decimalNumber = ConvertToDecimal(number);
            twentySixNumber = ConvertToTwentySixNumeral(decimalNumber);
            result.Append(twentySixNumber + " ");
        }
        Console.WriteLine(result.ToString().Trim());
    }

    static string ConvertToTwentySixNumeral(BigInteger decimalNumber)
    {
        char charToAdd = new char();
        StringBuilder twentySixNumber = new StringBuilder();

        while (decimalNumber > 0)
        {
            BigInteger remainder = decimalNumber % 26;
            charToAdd = (char)(remainder + 'a');
            twentySixNumber.Insert(0, charToAdd);
            decimalNumber /= 26;
        }
        return twentySixNumber.ToString();
    }

    static BigInteger ConvertToDecimal(string number)
    {
        BigInteger decimalNumber = 0;

        for (int i = 0; i < number.Length; i++)
        {
            BigInteger temp = (number[i] - 'a');
            BigInteger powedNumber = PowerofSeventeen(number.Length - 1 - i);

            decimalNumber += temp * powedNumber;
        }
        return decimalNumber;
    }


    static BigInteger PowerofSeventeen(int power)
    {
        BigInteger powedNum = 1;

        for (int i = 1; i <= power; i++)
        {
            powedNum *= 17;
        }
        return powedNum;
    }
}
