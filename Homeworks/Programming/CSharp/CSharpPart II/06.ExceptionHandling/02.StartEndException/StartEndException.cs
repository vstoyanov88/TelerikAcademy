//Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. 
//If an invalid number or non-number text is entered, the method should throw an exception. 
//Using this method write a program that enters 10 numbers:
//            a1, a2, … a10, such that 1 < a1 < … < a10 < 100


using System;

class StartEndException
{
    static int ReadNumber(int start, int end)
    {
        int number = 0;
        try
        {
            number = int.Parse(Console.ReadLine());
            if (number <= start || number > end)
            {
                throw new System.ArgumentOutOfRangeException();
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid type");
        }
        return number;
    }
    static void Main()
    {
        Console.WriteLine("Enter 10 numbers from 1 ot 100. Each entry must be bigger than the previous");
        int start = 0;
        int end = 100;
        int[] arr = new int[10];
        for (int i = 0; i < arr.Length; i++)
        {
            start = ReadNumber(start, end);
            arr[i] = start;
        }
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]+ " ");
        }
        Console.WriteLine();
    }
}

