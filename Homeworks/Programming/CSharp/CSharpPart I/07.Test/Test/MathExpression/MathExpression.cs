using System;

class MathExpression
{
    static void Main()
    {
        decimal n = decimal.Parse(Console.ReadLine());
        decimal m = decimal.Parse(Console.ReadLine());
        decimal p = decimal.Parse(Console.ReadLine());

        decimal nom = (n * n) + (1 / (m * p)) + 1337;
        decimal den = n - (128.523123123m * p);
        int modVal = ((int)m) % 180;
        decimal sinVal = (decimal)Math.Sin(modVal);

        decimal result = (nom / den) + sinVal;
        Console.WriteLine("{0:0.000000}", result);
    }
}

