using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


class TwoIsBetterThanOne
{
    static bool Print(string str)
    {
        foreach (char ch in str)
        {
            if (ch == '3' | ch=='5')
            {
                return true;
            }

        }
        return false;
    }
    static bool IsPalindrome(string str)
    {
        for (int i = 0; i < str.Length / 2; i++)
        {
            if (str[i] != str[str.Length - 1 - i])
            {
                return false;
            }
        }
        return true;
    }
    static void Main()
    {
        string input1 = Console.ReadLine();
        string[] arr = input1.Split();
        long a, b;
        a = long.Parse(arr[0]);
        b = long.Parse(arr[1]);
        long number=a;
        string str="";
        int count = 0;

        for (long j = a; j <= b; j += 2)
        {
            if (j % 10 == 3 | j % 10 == 5)
            {
                str = Convert.ToString(j);

                foreach (Match item in Regex.Matches(str, @"\w+"))
                {
                    if (Print(str))
                    {
                        if (IsPalindrome(item.Value))
                        {
                            count++;
                        }
                    }
                }
            }
        }
        //2

        string input2 = Console.ReadLine();
        decimal p = decimal.Parse(Console.ReadLine());
        string[] arr2 = input2.Split(',');
        decimal[] numbers = new decimal[arr2.Length];
        List<decimal> list = new List<decimal>();
        int count2 = 0;
        for (long i = 0; i < arr2.Length; i++)
        {
            numbers[i] = Convert.ToDecimal(arr2[i]);
        }

        for (long i = 0; i < numbers.Length; i++)
        {
            for (long j = 0; j < numbers.Length; j++)
            {
                if (numbers[i] >= numbers[j])
                {
                    count2++;
                }
            }
            if (Convert.ToDecimal(count2) >= numbers.Length * p / 100)
            {
                list.Add(numbers[i]);
            }
            count2 = 0;
        }
        list.Sort();
        Console.WriteLine(count);
        Console.WriteLine((long)(list[0]));
    }
}
