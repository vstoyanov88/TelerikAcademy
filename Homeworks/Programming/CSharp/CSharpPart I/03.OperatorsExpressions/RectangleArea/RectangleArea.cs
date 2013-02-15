using System;

class RectangleArea
{
    static void Main()
    {
        Console.WriteLine("Enter rectangle width:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter rectangle hight:");
        double h = double.Parse(Console.ReadLine());
        Console.WriteLine("Rectangle area={0}",a*h);
    }
}

