using System;

class MatrixN
{
    static void Main()
    {
        Console.Write("Enter value for n(n<20):");
        int n = int.Parse(Console.ReadLine());
        if (n < 20)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,3}", i + j);
                }
                Console.WriteLine();
            }
        }
        else 
        {
            Console.WriteLine("Invalid entry!");
        }
    }
}

