using System;

class FibonacciSequence
{
    static void Main()
    {
        Console.Write("How many elements this sequence to be: n=");
        int n = int.Parse(Console.ReadLine());
        decimal first = 0;
        decimal second = 1;
        decimal third = first + second;
        Console.Write(first + "," + second);
        for (int i = 2; i < n; i++)
        {
            Console.Write("," + third);
            first = second;
            second = third;
            third = first + second;
        }
    }
}

