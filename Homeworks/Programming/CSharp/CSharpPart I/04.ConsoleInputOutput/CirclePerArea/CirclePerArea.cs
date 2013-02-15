using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter value for radius:");
        double radius = double.Parse(Console.ReadLine());
        double pi = 3.14 ;
        double perimeter = 2*radius*pi;
        double area = (radius*radius)*pi;
        Console.WriteLine("Circle perimeter is: {0}",perimeter);
        Console.WriteLine("Circle area is: {0}", area);
    }
}

