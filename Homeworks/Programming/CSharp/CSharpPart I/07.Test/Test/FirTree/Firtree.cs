using System;

class FirTree
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            if (i <= n - 1)
            {
                for (int j = n - 1; j >= 1; j--)
                {
                    if (j <= i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                for (int k = 2; k < n; k++)
                {
                    if (k <= i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
            }
            else
            {
                for (int j = 1; j <= n - 1; j++)
                {
                    if (j == i - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                for (int k = n - 2; k >= 1; k--)
                {
                    if (k < i)
                    {
                        Console.Write(".");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}

