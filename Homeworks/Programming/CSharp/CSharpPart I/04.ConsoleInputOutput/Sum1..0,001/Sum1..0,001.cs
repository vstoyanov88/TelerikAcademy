﻿using System;

class Program
{
    static void Main()
    {
        double sum = 1;
        for (double i = 2; (1 / i) >= 0.001; i++) 
        {
            if (i%2==0)
            {
                sum = sum + 1/i ;
            }
            else
            {
                sum = sum - 1/i;
            }
        }
        Console.WriteLine("{0:0.00000}",sum);
    }
}

