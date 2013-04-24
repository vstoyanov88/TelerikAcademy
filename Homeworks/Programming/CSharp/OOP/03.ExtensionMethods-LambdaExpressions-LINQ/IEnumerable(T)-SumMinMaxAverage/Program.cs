//Implement a set of extension methods for IEnumerable<T> that implement the following group functions: 
//sum, product, min, max, average.


using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable_T__SumMinMaxAverage
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = new List<int>();
            numbers.Add(-2); numbers.Add(4); numbers.Add(5); numbers.Add(1); numbers.Add(5); numbers.Add(1);
            Console.WriteLine(numbers.GetMin());
            Console.WriteLine();

            decimal[] arr = new decimal[5];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
            }
            Console.WriteLine(arr.GetMax());
            Console.WriteLine(arr.GetProduct());
            Console.WriteLine(arr.GetSum());
            Console.WriteLine(arr.GetAverage());
        }
    }
}
