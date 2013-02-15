//Write a program that finds all prime numbers in the range [1...10 000 000].
//Use the sieve of Eratosthenes algorithm (find it in Wikipedia).

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int max = 10000;//000
        List<int> primeNumbers = new List<int>();
        for (int i = 2; i <= max; i++)
        {
            primeNumbers.Add(i);
        }
        double stop = Math.Sqrt((double)max);
        for (int i = 2; i <= stop; i++)
        {
            if (!primeNumbers.Contains(i))
            {
                continue;
            }
            for (int j = 2 * i; j <= max; j = j + i) 
            {
                primeNumbers.Remove(j);
            }
        }
        for (int i = 0; i < primeNumbers.Count; i++)
        {
            Console.Write(primeNumbers[i] + " ");
        }
        Console.WriteLine();
    }
}

