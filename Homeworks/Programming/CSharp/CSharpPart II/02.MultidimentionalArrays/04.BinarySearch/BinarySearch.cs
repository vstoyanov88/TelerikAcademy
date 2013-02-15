//Write a program, that reads from the console an array of N integers and an integer K,
//sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 

using System;

class Program
{
    static void Main()
    {
        int[] arr = { 6, 2, 6, 4, 7, 3, 7, 2, 4, 8, 3, 39, 3 };
        int number = 5;
        int temp = int.MinValue;
        Array.Sort(arr);
        int index = Array.BinarySearch(arr, number);
        index = 0;
        while (arr[index] <= number)
        {
            temp = arr[index];
            index++;
        }
        Console.WriteLine("K <=  is number {0} at position {1}",temp, index-1);
    }
}

