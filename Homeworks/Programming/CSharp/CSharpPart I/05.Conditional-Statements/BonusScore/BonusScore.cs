using System;

class BonusScore
{
    static void Main()
    {
        Console.Write("Enter a digit 1-9:");
        byte digit = byte.Parse(Console.ReadLine());
        if ((digit >= 1) & (digit <= 9))
        {
            switch (digit)
            {
                case 1: Console.WriteLine(digit * 10); break;
                case 2: Console.WriteLine(digit * 10); break;
                case 3: Console.WriteLine(digit * 10); break;
                case 4: Console.WriteLine(digit * 100); break;
                case 5: Console.WriteLine(digit * 100); break;
                case 6: Console.WriteLine(digit * 100); break;
                case 7: Console.WriteLine(digit * 1000); break;
                case 8: Console.WriteLine(digit * 1000); break;
                case 9: Console.WriteLine(digit * 1000); break;
            }
        }
        else
        {
            Console.WriteLine("Error!Wrong entry!");
        }
    }
}

