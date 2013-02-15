//* Write a program that sorts an array of integers using the merge sort algorithm (find it in Wikipedia).

using System;

class Program
{
    static int[] MergeSort(int[] arr)
    {
        if (arr.Length == 1)
        {
            return arr;
        }
        int middle = arr.Length / 2;
        int[] left = new int[middle];
        for (int i = 0; i < middle; i++)
        {
            left[i] = arr[i];
        }
        int[] right = new int[arr.Length - middle];
        for (int i = 0; i < right.Length; i++)
        {
            right[i] = arr[i + middle];
        }
        left = MergeSort(left);
        right = MergeSort(right);
        int leftSide = 0;
        int rightSide = 0;
      
        for (int i = 0; i < arr.Length; i++)
        {
            if (rightSide == right.Length || ((leftSide < left.Length) && (left[leftSide] <= right[rightSide])))
            {
                arr[i] = left[leftSide];
                leftSide++;
            }
            else if (leftSide == left.Length || ((rightSide < right.Length) && (right[rightSide] <= left[leftSide])))
            {
                arr[i] = right[rightSide];
                rightSide++;
            }
        }
        return arr;
    }
    static void Main()
    {
        int[] arr = { 0, 3, 6, -6, 3, 6, 43, 8, 64, 54, 3, -3, 4 };
        
        MergeSort(arr);
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
}

