//Write a program that finds in given array of integers a sequence of given sum S (if present).
//Example:	
//{4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}

using System;
using System.Collections.Generic;

class SequenceOfGivenSum
{
    static void Main()
    {
        int[] arr = { 4, 5, 3, 6, 8, 3, 8, 2, 4, 7, 3, 7, 8 };
        int sum = 13;
        int currentSum;
        for (int i = 0; i < arr.Length - 1; i++) 
        {
            currentSum = arr[i];
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (currentSum + arr[j] > sum)
                {
                    break;
                }
                if (currentSum + arr[j] < sum)
                {
                    currentSum += arr[j];
                }
                if (currentSum + arr[j] == sum)
                {   
                    for (int k = i; k <= j; k++)
                    {
                        Console.Write(arr[k] + " ");
                    }
                    return;
                }
            }   
        }
        Console.WriteLine();
    }   
}

