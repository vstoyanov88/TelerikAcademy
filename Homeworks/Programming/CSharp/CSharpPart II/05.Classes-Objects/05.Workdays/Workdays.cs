//Write a method that calculates the number of workdays between today and given date,
//passed as parameter. Consider that workdays are all days from Monday to Friday except a fixed list of public holidays
//specified preliminary as array.

using System;

class Workdays
{
    static void Main(string[] args)
    {
        DateTime[] holidays = {
                                new DateTime(2013, 3, 7),
                                new DateTime(2013, 4, 2),
                                new DateTime(2013, 5, 3),
                                new DateTime(2013, 6, 4),
                                new DateTime(2013, 7, 18)
                              };
        DateTime start = DateTime.Today;
        Console.WriteLine("enter date: YYYY/MM/DD: ");
        DateTime end = DateTime.Parse(Console.ReadLine());
        int daysBetween = (end - start).Days;
        int count = 0;
        for (int i = 0; i < daysBetween; i++)
        {
            start = start.AddDays(1);
            if (start.DayOfWeek != DayOfWeek.Saturday & start.DayOfWeek != DayOfWeek.Sunday)
            {
                for (int j = 0; j < holidays.Length; j++)
                {
                    if (start != holidays[j])
                    {
                        count++;
                        break;
                    }
                }
            }
        }
        Console.WriteLine("Number of working days in the period: {0}", count);
    }
}

