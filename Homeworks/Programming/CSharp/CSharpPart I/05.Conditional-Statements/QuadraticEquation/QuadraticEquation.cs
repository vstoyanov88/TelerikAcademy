using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Enter values for the equation: a*x*x + b*x + c = 0");
        Console.Write("a=");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b=");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c=");
        double c = double.Parse(Console.ReadLine());
        double x1, x2;
        double d =(b * b) - (4 * a * c);
        if (d < 0)
        {
            Console.WriteLine("No result");
        }
        if (d == 0)
        {
            x1 = (-b) / (2 * a);
            Console.WriteLine("x={0}", x1);
        }
        if (d > 0) 
        {
            x1 = (-b - (Math.Sqrt(d)) / (2 * a));
            x2 = (-b + (Math.Sqrt(d)) / (2 * a));
            Console.WriteLine("x1={0} , x2={1}", x1, x2);
        }
    }
}

