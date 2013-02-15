using System;

class AstrologicalDigits
{
    static void Main()
    {
        string n = Console.ReadLine();
        int number;
        do
        {
            number = 0;
            foreach (char ch in n)
            {
                if (ch != '.' && ch != '-')
                {
                    number += (int)(ch - '0');
                }
            }
            n = number.ToString();
        }
        while (number > 9);
        Console.WriteLine(number);
    }
}

