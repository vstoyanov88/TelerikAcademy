using System;


    class Program
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
            Console.WriteLine("The bit value at positon {0} of number {1} is {2}",position,number,bit);
        }
    }

