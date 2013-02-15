using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter number:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter bit position:");
        int p = int.Parse(Console.ReadLine());
        int mask = 1;
        mask = mask << p;
        int v =(n & mask) != 0 ? 1 : 0;
        Console.WriteLine("Current bit value: {0}", v);
        if (v == 0)
        {
            n = n | (1 << p);
        }
        else 
        {
            n = n & ~(1 << p);
        }
        Console.WriteLine("Changed bit value: {0} and new number {1}",Convert.ToString(n,2), n);
    }
}

