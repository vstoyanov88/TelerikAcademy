//Write a method that return the maximal element in a portion of array of integers starting at given index.
//Using it write another method that sorts an array in ascending / descending order.


using System;

class MaxElemInPortionofArray
{
    static int FindMaximalElem(int[] arr, int start, int end)
    {
        int max = 0;
        for (int i = start; i < end; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        return max;
    }
    static void Main()
    {
        int[] arr = { 6, 4, 7, 2, 36, 4, 9, 42, 6, 8, 4, 3 };
        int start = 1;
        int end = 6;
        Console.WriteLine(FindMaximalElem(arr,start,end));
    }
}

