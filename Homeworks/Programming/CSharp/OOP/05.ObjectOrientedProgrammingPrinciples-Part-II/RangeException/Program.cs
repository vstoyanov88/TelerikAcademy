//Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range.
//It should hold error message and a range definition [start … end].
//Write a sample application that demonstrates the InvalidRangeException<int> and InvalidRangeException<DateTime>
//by entering numbers in the range [1..100] and dates in the range [1.1.1980 … 31.12.2013].


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeException
{
    class Program
    {
        static void Main()
        {
            int min = 0;
            int max = 100;
            Console.WriteLine("Enter number in range {0} - {1}", min, max);
            int number = int.Parse(Console.ReadLine());
            if (number < min || number > max)
            {
                throw new InvalidRangeException<int>(min, max);
            }
            else
            {
                Console.WriteLine("correct entry");
            }
            DateTime minD = new DateTime(1980, 1, 1);
            DateTime maxD = new DateTime(2013, 12, 31);
            Console.WriteLine("Enter date in range {0} - {1}", minD, maxD);
            DateTime date = DateTime.Parse(Console.ReadLine());
            if (date < minD || date > maxD)
            {
                throw new InvalidRangeException<DateTime>(minD, maxD);
            }
            else
            {
                Console.WriteLine("correct entry");
            }
        }
    }
}
