using System;

class PrimeNumber
{
    static void Main()
    {
        Console.WriteLine("Enter whole number from 1 to 100:");
        int a = int.Parse(Console.ReadLine());
        int b = 2;
        bool c = true;
        while (c && (a > b))
        {
            if (a % b == 0)
            {
                c = false;
            }
            b = b++;
        }
        Console.WriteLine("The number is prime: {0}", c);
    }
}

