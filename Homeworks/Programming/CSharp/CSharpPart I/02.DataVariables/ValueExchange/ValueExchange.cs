using System;


class Program
{
    static void Main()
    {
        byte five = 5;
        byte ten = 10;
        Console.WriteLine("{0} {1}", five,ten);
        byte zero = five;
        five = ten;
        ten = zero;
        Console.WriteLine("{0} {1}",five,ten);
    }
}

