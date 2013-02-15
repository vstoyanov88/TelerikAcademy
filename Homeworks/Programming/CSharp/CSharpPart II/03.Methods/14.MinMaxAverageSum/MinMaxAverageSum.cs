//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. 
//Use variable number of arguments

using System;

class MinMaxAverageSum
{
    static int Min(int[] arr)
    {
        int min = int.MaxValue;
        for (int i = 0; i < arr.Length; i++)
        {
            if (min > arr[i])
            {
                min = arr[i];
            }
        }
        return min;
    }
    static int Max(int[] arr)
    {
        int max = int.MinValue;
        for (int i = 0; i < arr.Length; i++)
        {
            if (max < arr[i])
            {
                max = arr[i];
            }
        }
        return max;
    }
    static decimal Average(int[] arr)
    {
        decimal average = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            average += arr[i];
        }
        return (average / arr.Length);
    }
    static int Sum(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum;
    }
    static long Product(int[] arr)
    {
        long product = 1;
        for (int i = 0; i < arr.Length; i++)
        {
            product *= arr[i];
        }
        return product;
    }
    static void Main()
    {
        int[] arr = { 1, 7, 3, -2, 4, 65, 2, 45, -34, 5, 7, 34, 7, 6, -3, 45, 7, };
       
        Console.WriteLine("Min {0}",Min(arr));
        Console.WriteLine("Max {0}",Max(arr));
        Console.WriteLine("Average {0}",Average(arr));
        Console.WriteLine("Sum {0}",Sum(arr));
        Console.WriteLine("Product {0}",Product(arr));
    }
}

