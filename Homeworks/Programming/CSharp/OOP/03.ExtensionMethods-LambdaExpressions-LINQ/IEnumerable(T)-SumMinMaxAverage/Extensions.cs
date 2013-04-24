using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable_T__SumMinMaxAverage
{
    public static class Extensions
    {
        public static decimal GetSum<T>(this IEnumerable<T> numbers)
        {
            decimal sum = 0;
            foreach (var item in numbers)
            {
                sum += Convert.ToDecimal(item);
            }
            return sum;
        }

        public static decimal GetMin<T>(this IEnumerable<T> numbers) where T : IComparable
        {
            dynamic min = long.MaxValue;
            foreach (var item in numbers)
            {
                if (min > item)
                {
                    min = item;
                }
            }
            return min;
        }

        public static T GetMax<T>(this IEnumerable<T> numbers) where T : IComparable
        {
            dynamic max = long.MinValue;
            foreach (var item in numbers)
            {
                if (max < item)
                {
                    max = item;
                }
            }
            return max;
        }

        public static decimal GetAverage<T>(this IEnumerable<T> numbers)
        {
            decimal sum = 0;
            int count = 0;
            foreach (var item in numbers)
            {
                sum += Convert.ToDecimal(item);
                count++;
            }
            return sum/count;
        }

        public static decimal GetProduct<T>(this IEnumerable<T> numbers)
        {
            decimal product = 1;
            foreach (var item in numbers)
            {
                product *= Convert.ToDecimal(item);
            }
            return product;
        }
    }
}
