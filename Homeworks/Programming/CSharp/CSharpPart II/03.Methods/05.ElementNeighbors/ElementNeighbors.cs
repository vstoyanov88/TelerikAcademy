//Write a method that checks if the element at given position in given array 
//of integers is bigger than its two neighbors (when such exist).


using System;

class ElementNeighbors
{
    static bool CheckNeighbors(int[] arr, int element)
    {
        bool bigger = false;
        if (element>0 & element<arr.Length)
        {
            if (arr[element] > arr[element - 1] && arr[element] > arr[element + 1])
            {
                bigger= true;
            }
        }
        if (element == 0)
        {
            if (arr[element] > arr[element + 1])
            {
                bigger = true;
            }
        }
        if (element == arr.Length)
        {
            if (arr[element] > arr[element - 1])
            {
                bigger = true;
            } 
        }
        return bigger;
    }
    static void Main()
    {
        int[] arr = { 4, 7, 23, 8, 4, 2, 9, 4, 7 };
        int element = 0;
        Console.WriteLine(CheckNeighbors(arr,element));
    }
}

