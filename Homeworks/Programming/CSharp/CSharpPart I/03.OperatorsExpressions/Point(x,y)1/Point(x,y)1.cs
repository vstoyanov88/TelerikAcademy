using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter value for x:");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for y:");
        double y = double.Parse(Console.ReadLine());
        if ((x - 1) * (x - 1) + (y - 1) * (y - 1) <= 9)
        {
            if ((x < (-1)) || (x > 5))
            {
                Console.WriteLine("The point is in the circle, out of the rectangle");
            }
            else
            {
                if ((y < (-1)) || (y > 1))
                {
                    Console.WriteLine("The point is in the circle, out of the rectangle");
                }
                else 
         
                {
                    Console.WriteLine("The point is in the circle and in the rectangle");
                }
            }
        }
        else
        {
            Console.WriteLine("The point is out of the circle");
        }
    }
}

