using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number: n=");
        long n = long.Parse(Console.ReadLine());
        for (long i = 0; i <= n; i++)
        {
            Console.Write(i + ",");
        }
    }
}

