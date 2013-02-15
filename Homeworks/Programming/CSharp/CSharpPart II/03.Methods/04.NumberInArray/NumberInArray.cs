//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is working correctly.


using System;

class NumberInArray
{
    static int NumAppear(int[] arr)
    {
        int number = 0;
        int count = 1;
        int max = 0;
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                {
                    count++;
                    if (count > max)
                    {
                        max = count;
                        number = arr[j];
                    }
                }
            }
            count = 1;
        }
        return number;
    }
    static void Main()
    {
        int[] arr = { 5, 7, 2, 2, 6, 3, 5, 8, 2, 3, 2, 5, 8, 9 };
        Console.WriteLine(NumAppear(arr));
    }
}

