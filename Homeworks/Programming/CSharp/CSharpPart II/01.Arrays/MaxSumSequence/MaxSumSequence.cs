//Write a program that finds the sequence of maximal sum in given array. 
//Example:
//    {2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
//    Can you do it with only one loop (with single scan through the elements of the array)?


using System;

class MaxSumSequence
{
    static void Main()
    {
        int[] arr = { 2, 4, -5, 5, -6, 3, -1, 5 };
        int maxSum = 0;
        int currentSum;
        int start = 0;
        int end = 0;
        for (int i = 0; i < arr.Length-1; i++)
        {
            if (arr[i] > 0) 
            {
                currentSum = arr[i];
                for (int j = 1 + i; j < arr.Length; j++) 
                {
                    if (currentSum + arr[j] > 0)
                    {
                        currentSum += arr[j];
                        if (currentSum > maxSum)
                        {
                            maxSum = currentSum;
                            start = i;
                            end = j;
                        }
                    }
                    else
                    {
                        break;
                    }  
                }
            }
        }
        for (int i = start; i <= end; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}
