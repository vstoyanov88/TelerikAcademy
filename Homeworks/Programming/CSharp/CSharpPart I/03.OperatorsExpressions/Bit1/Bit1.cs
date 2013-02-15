using System;

    class Bit1
    {
        static void Main()
        {
            Console.WriteLine("Enter number:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter bit position:");
            int position = int.Parse(Console.ReadLine());
            int mask = 1;
            mask = mask << position;
            int newmask = number & mask;
            int bit = newmask >> position;
            Console.WriteLine("The bit at position {0} of number {1} is 1: {2}",position,number,bit==1);
        }
    }

