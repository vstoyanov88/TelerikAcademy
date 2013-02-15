using System;

class BitsExchange
{
    static void Main()
    {
        Console.WriteLine("Enter number:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter near bit position p:");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter far bit position q(q>p):");
        int q = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter how many (k) bits to exchange:");
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine("n before chaning: {0}", n);
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
        for (int i = 0; i < k; i++)
        {
            int bitP = n & (1 << p);
            int bitQ = n & (1 << q);
            n = n & ~(1 << p);
            n = n & ~(1 << q);
            bitP = bitP << (q - p);
            bitQ = bitQ >> (q - p);
            n = n | bitP;
            n = n | bitQ;
            p++;
            q++;
        }
        Console.WriteLine("n after changing: {0}", n);
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(32,'0'));
    }
}

