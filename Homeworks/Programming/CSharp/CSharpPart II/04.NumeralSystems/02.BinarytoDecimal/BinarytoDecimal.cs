using System;

class BinarytoDecimal
{
    static void Main()
    {
        int[] arr = { 1, 1, 0, 1, 0, 1, 0 };
        Array.Reverse(arr);
        int number = 0;
        for (int i = 0; i <arr.Length; i++)
        {
            number +=arr[i]*(int)Math.Pow(2,(i));
        }
        Console.WriteLine(number);
    }
}

