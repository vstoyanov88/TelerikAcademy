//Write a program that finds the index of given element in a sorted array of integers
//by using the binary search algorithm (find it in Wikipedia).


using System;

class Bibarysearch
{
    static void Main()
    {
        int[] arr = { 2, 4, 7, 15, 16, 23, 31, 65 };
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        int min=0;
        int max=arr.Length-1;
        while (max >= min) 
        {
            int middle = (min + max) / 2;
            if (number > arr[middle])
            {
                min = middle + 1;
            }
            else if (number < arr[middle])
            {
                max = middle - 1;
            }
            else
            {
                Console.WriteLine("The number is at position {0}",middle);
                return;
            }
        }
        Console.WriteLine("The number was not fount in this array");
    }
}

