using System;


class ThirdDigit7
{
    static void Main()
    {
        Console.WriteLine("Enter whole number:");
        int a = Math.Abs(int.Parse(Console.ReadLine()));
        int b = a / 100;
        bool c = (b % 10 == 7);
        Console.WriteLine("The third digit(right to left) of the number is 7: {0}",c);
    }
}

