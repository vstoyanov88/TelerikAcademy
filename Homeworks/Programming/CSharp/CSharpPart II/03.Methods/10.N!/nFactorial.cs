//Write a program to calculate n! for each n in the range [1..100].
//Hint: Implement first a method that multiplies a number represented as array of digits by given integer number. 


using System;
using System.Numerics;

class nFactorial
{
    static BigInteger Factorial(int n)
    {
        BigInteger number = 1;
        for (int i = 1; i <= n; i++)
        {
            number = number * i;
        }
        return number;
    }
    static void Main()
    {   
        int[] arr = new int[100];
        int n = 0;
        for (int i = 1; i <= arr.Length; i++)
        {
            n = i;
            Console.WriteLine(Factorial(n));
        }
        
    }
}

