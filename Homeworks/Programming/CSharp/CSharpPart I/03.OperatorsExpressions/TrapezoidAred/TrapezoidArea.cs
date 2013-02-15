using System;


class TrapezoidArea
{
    static void Main()
    {
        Console.WriteLine("Enter value for side a:");
        float a = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for side b:");
        float b = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for hight h:");
        float h = float.Parse(Console.ReadLine());
        float s = (((a + b) / 2) * h);
        Console.WriteLine("The trapezoid's area is: {0}", s);
    }
}

