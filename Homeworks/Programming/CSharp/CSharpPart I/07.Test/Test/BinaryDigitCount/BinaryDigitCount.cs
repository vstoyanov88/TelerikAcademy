using System;

class BinaryDigitsCountm
{
    static void Main()
    {
        byte b = byte.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        int count;
        for (int i = 1; i <= n; i++)
        {
            count = 0;
            uint number = uint.Parse(Console.ReadLine());
            while (number != 0)
            {
                if ((number & 1) == b)
                {
                    count++;
                }
                number = number >> 1;
            }
            Console.WriteLine(count);
        }
    }
}

