//Write a program that compares two char arrays lexicographically (letter by letter).


using System;

class CompareCharArr
{
    static void Main()
    {
        char[] arr1 = { 'a', 'b', 'c', 's' };
        char[] arr2 = { 'a', 'b', 'c', 't' };
        int length, result = 0;

        if (arr1.Length<=arr2.Length)
        {
            length = arr1.Length;
        }
        else
        {
            length = arr2.Length;
        }

        for (int i = 0; i < length; i++)
        {
            if (arr1[i] < arr2[i]) 
            {
                result = 1;
                break;
            }
            else if (arr1[i] > arr2[i])
            {
                result = 2;
                break;
            }
        }
        if (result == 1)
        {
            Console.WriteLine("Array1 is before array2");
        }
        else if (result == 2)
        {
            Console.WriteLine("Array2 is before array1");
        }
        else
        {
            if (arr1.Length < arr2.Length)
            {
                Console.WriteLine("Array1 is before array2");
            }
            else if (arr1.Length > arr2.Length)
            {
                Console.WriteLine("Array2 is before array1");
            }
            else
            {
                Console.WriteLine("Array1 is equal to array2");
            }
        }
    }
}

