//Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.

using System;

class LeapYear
{
    static void Main()
    {
        Console.WriteLine("enter year: ");
        int year = int.Parse(Console.ReadLine());
        Console.WriteLine("Year {0} is leap? {1}", year, DateTime.IsLeapYear(year));
    }
}

