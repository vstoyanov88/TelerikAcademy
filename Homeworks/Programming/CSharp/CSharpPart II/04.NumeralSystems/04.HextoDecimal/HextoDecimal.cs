using System;
using System.Collections.Generic;

class HextoDecimal
{
    static void Main()
    {
        List<int> list = new List<int>();
        string number = "ABCDEF";
        foreach (char ch in number)
        {
            switch (ch)
            {
                case '0': list.Add(0); break;
                case '1': list.Add(1); break;
                case '2': list.Add(2); break;
                case '3': list.Add(3); break;
                case '4': list.Add(4); break;
                case '5': list.Add(5); break;
                case '6': list.Add(6); break;
                case '7': list.Add(7); break;
                case '8': list.Add(8); break;
                case '9': list.Add(9); break;
                case 'A': list.Add(10); break;
                case 'B': list.Add(11); break;
                case 'C': list.Add(12); break;
                case 'D': list.Add(13); break;
                case 'E': list.Add(14); break;
                case 'F': list.Add(15); break;
            }
        }
        int numDEc = 0;
        int[] arr = new int[list.Count];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = list[i];
        }
        Array.Reverse(arr);
        for (int i = arr.Length-1; i >= 0; i--)
        {
            numDEc += arr[i] * (int)Math.Pow(16, i);
        }
        Console.WriteLine(numDEc);
    }
}

