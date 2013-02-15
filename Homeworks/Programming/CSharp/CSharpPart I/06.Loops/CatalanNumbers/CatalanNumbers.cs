using System;

    class CatalanNumbers
    {
        static void Main()
        {
            Console.Write("Enter n=");
            int n = int.Parse(Console.ReadLine());
            decimal c = 0;
            decimal factorialN = 1;
            decimal factorial2N = 1;
            for (int i = 1; i <= n; i++)
            {
                factorialN = factorialN * i;
            }
            decimal factorialN1 = factorialN * (n + 1);
            for (int i = 1; i <= n * 2; i++)
            {
                factorial2N = factorial2N * i;
            }
            c = factorial2N / (factorialN1 * factorialN);
            Console.WriteLine(c);
        }
    }