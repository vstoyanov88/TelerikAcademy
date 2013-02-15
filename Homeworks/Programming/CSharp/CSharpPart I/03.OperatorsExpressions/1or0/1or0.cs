using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("Enter number:");
        int number = int.Parse(Console.ReadLine());
        int mask = 1;
        mask = mask << 3;
        int newMask = number & mask;
        int bit = newMask >> 3;
        Console.WriteLine("The third bit is 1: {0}", bit);
    }
}

