using System;
using System.Collections.Generic;

class DecimalToHex
{
    static void Main()
    {
        Console.WriteLine("Enter number");
        int number = int.Parse(Console.ReadLine());
        List<string> list = new List<string>();
        while (number > 0)
        {
            switch (number % 16)
            {
                case 10: list.Add("A"); break;
                case 11: list.Add("B"); break;
                case 12: list.Add("C"); break;
                case 13: list.Add("D"); break;
                case 14: list.Add("E"); break;
                case 15: list.Add("F"); break;
                default: list.Add(""+number % 16); break;
            }
            number = number / 16;
        }
        Console.WriteLine("number in hex");
        for (int i = list.Count-1; i >= 0; i--)
        {
            Console.Write(list[i]);
        }
        Console.WriteLine();
    }
}

