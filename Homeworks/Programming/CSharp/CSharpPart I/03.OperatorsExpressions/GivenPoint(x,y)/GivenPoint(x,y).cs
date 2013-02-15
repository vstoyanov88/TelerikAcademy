using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter value for x:");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for y:");
        double y = double.Parse(Console.ReadLine());
        if ((x * x) + (y * y) <= 25)
        { 
            Console.WriteLine("The point(x,y) is in the circle K(0,5)");
        }
        else Console.WriteLine("The point(x,y) is not in the circle K(0,5)");
    }
}
