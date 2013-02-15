using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter value for x:");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Enter value for n:");
        int n = int.Parse(Console.ReadLine());
        double s = 1;
        double factorial = 1;
        double factorialX = 1;
        for (int i = 1; i <= n;i++)
        {
            factorial = factorial * i;
            factorialX = factorialX * x;
            s = s + (factorial / factorialX);
        }
        Console.WriteLine("1 + 1!/x + 2!/x2 +...+ N!/xN = {0}",s);
    }
}

