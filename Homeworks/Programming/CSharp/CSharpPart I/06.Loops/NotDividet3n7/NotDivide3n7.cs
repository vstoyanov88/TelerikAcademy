using System;

    class NotDivide3n7
    {
        static void Main()
        {
            Console.Write("Enter number: n=");
            long n = long.Parse(Console.ReadLine());
            for (long i = 0; i <= n; i++)
            {
                if (i % 21 > 0) 
                {
                    Console.Write(i + ",");
                }
            }
        }
    }

