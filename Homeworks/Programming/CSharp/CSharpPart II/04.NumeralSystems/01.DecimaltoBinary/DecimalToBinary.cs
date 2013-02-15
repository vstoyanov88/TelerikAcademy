using System;
using System.Collections.Generic;

class DecimalToBinary
{
    static void Main()
    {
        Console.WriteLine("Enter number:");
        int number = int.Parse(Console.ReadLine());
        List<int> list=new List<int>();
        while (number > 0)
        {
            list.Add(number % 2);
            number = number / 2;
        }
        Console.WriteLine("Number in binary:");
        for (int i = list.Count-1; i >= 0; i--)
        {
            Console.Write(list[i]);
        }
        Console.WriteLine();
    }
}

