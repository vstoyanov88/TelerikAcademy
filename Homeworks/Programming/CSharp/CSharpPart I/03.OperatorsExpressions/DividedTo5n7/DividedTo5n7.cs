using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("Enter four digit whole number:");
        int a = int.Parse(Console.ReadLine());
        bool b = (a % 5 == 0) && (a % 7 == 0);
        Console.WriteLine(b);
    }
}
