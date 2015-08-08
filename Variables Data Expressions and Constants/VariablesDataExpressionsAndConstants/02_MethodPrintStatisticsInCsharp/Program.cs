/*
Task 2. Method PrintStatistics in C#

    Refactor the following code to apply variable usage and naming best practices:

    public void PrintStatistics(double[] arr, int count)
    {
        double max, tmp;
        for (int i = 0; i < count; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        PrintMax(max);
        tmp = 0;
        max = 0;
        for (int i = 0; i < count; i++)
        {
            if (arr[i] < max)
            {
                max = arr[i];
            }
        }
        PrintMin(max);

        tmp = 0;
        for (int i = 0; i < count; i++)
        {
            tmp += arr[i];
        }
        PrintAvg(tmp/count);
    }

*/

public class PrintData
{
    public void PrintStatistics(double[] dataCollection, int count)
    {
        double maxValue = double.MinValue;
        
        for (int i = 0; i < count; i++)
        {
            if (dataCollection[i] > maxValue)
            {
                maxValue = dataCollection[i];
            }
        }

        PrintMaxValue(maxValue);
        
        double minValue = double.MaxValue;
        for (int i = 0; i < count; i++)
        {
            if (dataCollection[i] < minValue)
            {
                minValue = dataCollection[i];
            }
        }

        PrintMinValue(minValue);

        double sum = 0;
        for (int i = 0; i < count; i++)
        {
            sum += dataCollection[i];
        }

        double averageValue = sum / count;
        PrintAverageValue(averageValue);
    }












}

