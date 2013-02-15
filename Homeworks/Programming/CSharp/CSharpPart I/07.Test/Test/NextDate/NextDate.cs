using System;

class Program
{
    static void Main()
    {
        int day = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());
        if ((month == 12) && (day == 31))
        {
            day = 1;
            month = 1;
            year += 1;
        }
        
        else if ((day == 30) && ((month == 4) || (month == 6) || (month == 9) || (month == 11)))
        {
            day = 1;
            month += 1;
        }
        else if (day == 31)
        {
            day = 1;
            month += 1;
        }
        else if ((month == 2) && (day == 28) && ((year != 2000) || (year != 2004) || (year != 2008) || (year != 2012)))
        {
            day = 1;
            month += 1;
        }
        else if ((month == 2) && (day == 28) && ((year == 2000) || (year == 2004) || (year == 2008) || (year == 2012)))
        {
            day += 1;
        }
        else if ((month == 2) && (day == 29) && ((year == 2000) || (year == 2004) || (year == 2008) || (year == 2012)))
        {
            day = 1;
            month += 1;
        }
        else if ((day <= 30) && (month != 4) && (month != 6) && (month != 9) && (month != 11))
        {
            day += 1;
        }
        else if ((day <= 29) && (month != 2))
        {
            day += 1;
        }

        Console.WriteLine("{0}.{1}.{2}",day, month, year);
    }
}

