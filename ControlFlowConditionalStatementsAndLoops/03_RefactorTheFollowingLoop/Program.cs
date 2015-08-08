/*3. Refactor the following loop

int i=0;
for (i = 0; i < 100;) 
{
   if (i % 10 == 0)
   {
    Console.WriteLine(array[i]);
    if ( array[i] == expectedValue ) 
    {
       i = 666;
    }
    i++;
   }
   else
   {
        Console.WriteLine(array[i]);
    i++;
   }
}
// More code here
if (i == 666)
{
    Console.WriteLine("Value Found");
}
*/

using System;

public class Refactor
{
    static void Main()
    {
        int maxElement = 100;
        int expectedValue = 666;
        bool valueFound = false;
        for (int i = 0; i < maxElement; i++)
        {
            if (array[i] == expectedValue)
            {
                valueFound = true;
                break;
            }
        }
        if (valueFound)
        {
            Console.WriteLine("Value Found");
        }
    }
}
    



