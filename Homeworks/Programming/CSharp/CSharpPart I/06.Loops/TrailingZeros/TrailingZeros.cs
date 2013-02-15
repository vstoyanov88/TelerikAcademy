using System;
using System.Numerics;


    class TrailingZeros
{
    static void Main()
    {
        Console.Write("Enter n=");
        int n = int.Parse(Console.ReadLine());
        BigInteger factorial = 1;
        int count = 0;
        for (int i = 1; i <= n; i++)
        {
            factorial = factorial * i;   
        }
        while (factorial % 10 == 0)
        {
            count++;
            factorial = factorial / 10;
        }
        Console.WriteLine("There are {0} trailing zeros in n!", count);
    }
}

