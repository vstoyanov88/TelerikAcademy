using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter three real numbers \na=");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b=");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c=");
        double c = double.Parse(Console.ReadLine());
        byte count = 0;
        if ((a == 0) | (b == 0) | (c == 0))
        {
            Console.WriteLine("At least one of the numbers is 0 ! Try again!");
        }
        else
        {
            if (a < 0)
            {
                count++;
            }
            if (b < 0)
            {
                count++;
            }
            if (c < 0)
            {
                count++;
            }

            if ((count == 1) | (count == 3))
            {
                Console.WriteLine("The sign is -");
            }
            else
            {
                Console.WriteLine("The sign is +");
            }
        }
    }
}

