using System;

class TelerikLogo
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = x;
        int z = (x + 1) / 2;
        for (int row1 = 1; row1 <= x; row1++)
        {
            for (int a = (x / 2) + 1; a >= 1; a--)
            {
                if (a == row1)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }
            for (int b = 2; b <= x; b++)
            {
                if (b == row1)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }
            for (int c = x - 1; c >= 2;c-- )
            {
                if (c == row1)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }
            for (int d = 1; d <= (x / 2) + 1; d++) 
            {
                if (d == row1)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }
                Console.WriteLine();
        }
        for (int row2 = 1; row2 <= x-1; row2++)
        {
            for (int e = x +(x/2 - 1) ; e >= 0; e--)
            {
                if (e == row2)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }
            for (int f = 1; f <= x + (x / 2 - 1); f++)
            {
                if (f == row2)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }
                Console.WriteLine();
        }
        for (int row3 = 1; row3 <= (x - 1); row3++)
        {
            for (int g = x; g < x+(x / 2 + 1);g++ )
            {
                if (g == row3)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }
            for (int h = 1; h <= x - 1; h++)
            {
                if (h == row3)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }
            for (int i = x - 2; i >= 1; i--) 
            {
                if (i == row3)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }
            for (int j=x;j<x+(x/2+1);j++)
            {
                Console.Write(".");
            }
            Console.WriteLine();
        }
    }
}

