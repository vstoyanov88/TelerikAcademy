//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the "selection sort" algorithm: Find the smallest element, move it at the first position, 
//find the smallest from the rest, move it at the second position, etc.


using System;

class SortingArray
{
    static void Main()
    {
        int[] arr = { 1, 4, 6, 2, 7, 4, 9, 4, 7 };
        int temp,min;

        for (int i = 0; i < arr.Length-1; i++)
        {
            for (int j = i+1; j < arr.Length; j++)
            {
                if (arr[i] > arr[j]) 
                {
                    min = arr[j];
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }            
            }
        }
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}

