using System;
using System.Numerics;

class Tribonacci
{
    static void Main()
    {
        BigInteger number1 = BigInteger.Parse(Console.ReadLine());
        BigInteger number2 = BigInteger.Parse(Console.ReadLine());
        BigInteger number3 = BigInteger.Parse(Console.ReadLine());
        BigInteger sum = 0;
        int n = int.Parse(Console.ReadLine());
        for (int i = 4; i <= n; i++)
        {
            sum = number1 + number2 + number3;
            number1 = number2;
            number2 = number3;
            number3 = sum;
        }
        Console.WriteLine(sum);
    }
}

