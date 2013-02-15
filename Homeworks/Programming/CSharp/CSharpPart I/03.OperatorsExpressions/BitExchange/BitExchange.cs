using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter number:");
        uint n = uint.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
        uint mask = 1;
        uint mask3 = n & (mask << 3);
        uint mask4 = n & (mask << 4);
        uint mask5 = n & (mask << 5);
        uint mask24 = n & (mask << 24);
        uint mask25 = n & (mask << 25);
        uint mask26 = n & (mask << 26);
        mask3 = mask3 << 21;
        mask4 = mask4 << 21;
        mask5 = mask5 << 21;
        mask24 = mask24 >> 21;
        mask25 = mask25 >> 21;
        mask26 = mask26 >> 21;
        n = n & (~(mask << 3)) & (~(mask << 4)) & (~(mask << 5)) & (~(mask << 24)) & (~(mask << 25)) & (~(mask << 26));
        n = (((((n | mask3) | mask4) | mask5) | mask24) | mask25) | mask26;
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(32,'0'));
        Console.WriteLine(n);
    }
}

