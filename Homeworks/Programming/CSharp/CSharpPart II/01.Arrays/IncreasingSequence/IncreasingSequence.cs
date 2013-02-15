//Write a program that finds the maximal increasing sequence in an array.
//Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.


using System;

class IncreasingSequence
{
    static void Main()
    {
        int[] arr = { 3, 2, 3, 4, 5, 6, 2, 2, 4, 5, 6, 7 };
        int number = 0;
        int count = 1;
        int max = 0;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] == (arr[i+1] - 1))
            {
                count += 1;  
                if (count > max)
                {
                    max = count;
                    number = arr[i] + 1;
                }
            }
            else
            {
                count = 1;
            }
        }

        for (int i = (number - max + 1); i <= number; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}

