using System;
using System.Collections.Generic;

class SegmentDigits
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        string[] str = { "1111110", "0110000", "1101101", "1111001", "0110011", "1011011", "1011111", "1110000", "1111111", "1111011" };
        List<int> list = new List<int>();
        string[] input = new string[n];
        for (int i = 0; i < input.Length; i++)
        {
            input[i] = Console.ReadLine();
        }
        foreach (string s in input)
        {
            foreach (char ch in s)
            {
                if (ch == 0)
                {
 
                }
            }
        }
        //for (int i = 0; i < input.Length; i++)
        //{
        //    for (int j = 0; j < input[i].Length; j++)
        //    {
        //        if (i[j] == 0)
        //        {
 
        //        }
        //    }
        //}
        for (int i = 0; i < input.Length; i++)
        {
            for (int j = 0; j < str.Length; j++)
            {
                if (input[i] == str[j])
                {
                    list.Add(arr[j]);
                }
            }
        }
        Console.WriteLine(list.Count);
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }
    }
}

