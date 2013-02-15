//Write a program that reads a date and time given in the format: day.month.year 
//hour:minute:second and prints the date and time after 6 hours and 30 minutes
//(in the same format) along with the day of week in Bulgarian.


using System;
using System.Globalization;

class DayInBG
{
    static void Main()
    {
        string sample = "3.02.2013 00:00:00";
        DateTime date = DateTime.Parse(sample);
        date = date.AddHours(6.5);
        Console.WriteLine("{0} {1}",date.ToString("dddd", new CultureInfo("bg")),date);
    }
}

