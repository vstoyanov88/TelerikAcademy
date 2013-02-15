//Write a program that reads two arrays from the console and compares them element by element.

using System;

class ArrCompare
{
    static void Main()
    {
        Console.WriteLine("Enter length for the first array: ");
        int a = int.Parse(Console.ReadLine());
        int[] arr1= new int[a];
        for (int i = 0; i < a; i++)
        {
            Console.WriteLine("enter element: ");
            arr1[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Enter length for the second array: ");
        int b = int.Parse(Console.ReadLine());
        int[] arr2 = new int[b];
        for (int i = 0; i < b; i++)
        {
            Console.WriteLine("Enter element: ");
            arr2[i] = int.Parse(Console.ReadLine());
        }

        bool equal = true;
        if (a == b)
        {
            for (int i = 0; i < a; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    equal = false;
                }
            }
        }
        else
        {
            equal = false;
        }
        Console.WriteLine("Array1 is equal to array2: {0}", equal);
    }
}

