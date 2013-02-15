using System;

class SandGlass
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int row1 = 1; row1 <= (n/2)+1; row1++)
        {
            for (int i = 1; i <= (n / 2) + 1; i++)
            {
                if (i >= row1)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }
            for (int j = n / 2; j >= 1; j--)
            {
                if (j >= row1)
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
        for (int row2 = n / 2; row2 >= 1; row2--)
        {
            for (int k = 1; k <= (n / 2) + 1; k++)  
            {
                if (k<row2)
                {
                    Console.Write(".");
                }
                else
                {
                    Console.Write("*");
                }
            }
            for (int g = n / 2; g >= 1; g--) 
            {
                if (g >= row2)
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
    }
}

