using System;

class GreatesCommondivisor
{
    static void Main()
    {
        Console.Write("Enter two numbers (a≠b): a=");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b=");
        int b = int.Parse(Console.ReadLine());
        int divider = 1;
        int difference;
        if (a > b)
        {
            difference = a - b;
            for (int i = 1; i <= difference; i++)
            {
                if (difference % i == 0)
                {
                    divider = i;
                }
            }
        }
        else
        {
            difference = b - a;
            for (int i = 1; i <= difference; i++)
            {
                if (difference % i == 0)
                {
                    divider = i;
                }
            }
        }
        Console.WriteLine(divider);
    }
}

