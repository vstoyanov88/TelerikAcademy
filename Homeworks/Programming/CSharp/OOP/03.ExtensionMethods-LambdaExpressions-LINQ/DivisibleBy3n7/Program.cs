//Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last
//name in descending order. Rewrite the same with LINQ.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisibleBy3n7
{
    class Program
    {
        static void Main()
        {
            int[] arr = { 234, 43, 64, 21, 654, 34, 54, 84, 147 };
            var numbers =
                from number in arr
                where number % 21 == 0
                select number;
            foreach (int number in numbers)
            {
                Console.WriteLine(number + " ");
            }
            Console.WriteLine();

            List<int> list = new List<int>(){ 234, 42,63, 64, 21, 654, 34, 54, 84, 147 };
            List<int> numbers2 = list.FindAll(number => (number % 21) == 0);
            foreach (int number in numbers2)
            {
                Console.WriteLine(number + " ");
            }
        }
    }
}
