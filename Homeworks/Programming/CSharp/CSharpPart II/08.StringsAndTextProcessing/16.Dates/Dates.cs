using System;


    class Dates
    {
        static void Main()
        {
            string first="27.02.2006";
            string second="3.03.2006";
            DateTime firstDate = DateTime.Parse(first);
            DateTime secondDate = DateTime.Parse(second);
            Console.WriteLine(Math.Abs((firstDate-secondDate).TotalDays));
        }
    }

