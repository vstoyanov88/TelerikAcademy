using System;



class FloatCompare
{
    static void Main()
    {
        float a = 5.1f;
        float b = 5.2f;
        Console.WriteLine("{0} {1}", a, b);
        bool compareab = Math.Abs(a - b) <= 0.000001;
        bool compareab1 = (a == b);
        Console.WriteLine(compareab);
        Console.WriteLine(compareab1);

        Console.WriteLine("Enter first number:");
        decimal c = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        decimal d = decimal.Parse(Console.ReadLine());
        bool compareCD = (Math.Abs(c-d) <= 0.000001m);
        Console.WriteLine("{0} is equal to {1}: {2}",c,d,compareCD);
    }
}

