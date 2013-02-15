using System;

class Carpets
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int row = 1; row <= (n / 2); row++)
        {
            for (int a = n/2; a >= 1; a--)
            {
                if (a > row)
                {
                    Console.Write(".");
                }
                else
                {
                    if (row % 2 == 0)
                    {
                        if ((a == row) || ((a % 2 == 0) && (a < row)))
                        {
                            Console.Write("/");
                        }
                        if ((a % 2 != 0) && (a < row))
                        {
                            Console.Write(" ");
                        }
                    }
                    else
                    {
                        if ((a == row) || ((a % 2 != 0) && (a < row)))
                        {
                            Console.Write("/");
                        }
                        if ((a % 2 == 0) && (a < row))
                        {
                            Console.Write(" ");
                        }
                    }
                }
            }
            for (int b = 1; b <= n / 2; b++)
            {
                if (b > row)
                {
                    Console.Write(".");
                }
                else
                {
                    if (row % 2 == 0)
                    {
                        if ((b == row) || ((b % 2 == 0) && (b < row)))
                        {
                            Console.Write("\\");
                        }
                        if ((b % 2 != 0) && (b < row))
                        {
                            Console.Write(" ");
                        }
                    }
                    else
                    {
                        if ((row == b) || ((b % 2 != 0) && (b < row)))
                        {
                            Console.Write("\\");
                        }
                        if ((b < row) && (b % 2 == 0))
                        {
                            Console.Write(" ");
                        }
                    }
                }
            }
                Console.WriteLine();
        }
        for (int row1 = 1; row1 <= n / 2; row1++)
        {
            for (int c = 1; c <= n / 2; c++)
            {
                if (row1 > c)
                {
                    Console.Write(".");
                }
                else
                {
                    if (row1 % 2 == 0)
                    {
                        if ((row1 == c) || ((c % 2 == 0) && (c > row1)))
                        {
                            Console.Write("\\");
                        }
                        if ((c % 2 != 0) && (c > row1))
                        {
                            Console.Write(" ");
                        }
                    }
                    else
                    {
                        if ((c == row1) || ((c % 2 != 0) && (c > row1)))
                        {
                            Console.Write("\\");
                        }
                        if ((c % 2 == 0) && (c > row1))
                        {
                            Console.Write(" ");
                        }
                    }
                }
            }
            for (int d = n / 2; d >= 1; d--)
            {
                if (row1 > d)
                {
                    Console.Write(".");
                }
                else
                {
                    if (row1 % 2 == 0)
                    {
                        if ((row1 == d) || ((d % 2 == 0) && (d > row1)))
                        {
                            Console.Write("/");
                        }
                        if ((d % 2 != 0) && (d > row1))
                        {
                            Console.Write(" ");
                        }
                    }
                    else
                    {
                        if ((row1 == d) || ((d % 2 != 0) && (d > row1)))
                        {
                            Console.Write("/");
                        }
                        if ((d % 2 == 0) && (d > row1))
                        {
                            Console.Write(" ");
                        }
                    }
                }
            }
                Console.WriteLine();
        }
    }
}

