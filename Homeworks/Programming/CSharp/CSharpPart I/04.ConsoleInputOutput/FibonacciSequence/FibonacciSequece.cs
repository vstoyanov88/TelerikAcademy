using System;

class FibonacciSequece
{
    static void Main()
    {
        decimal num = 0;
        decimal num1 = 1;
        decimal num2 = 0;
        Console.Write("{0},", num);
        Console.Write("{0},",num1);
        for (int i = 1; i < 99; i++)
        {
            num = num1 + num2;
            num2 = num1;
            num1 = num;
            Console.Write("{0},",num);
        }
    }
}

