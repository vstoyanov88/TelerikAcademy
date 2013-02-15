using System;


    class QuadraticQuation
    {
        static void Main()
        {
            Console.WriteLine("Enter value for a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter value for c:");
            double c = double.Parse(Console.ReadLine());
            double d = Math.Sqrt((b * b) - (4 * a * c));
            if (d <= 0)
            {
                if (d == 0)
                {
                    Console.WriteLine("d=0, so x=0");
                }
                else
                {
                    Console.WriteLine("No solution");
                }
            }
            else
            {
                double x1 = (-b + d) / 2 * a;
                double x2 = (-b - d) / 2 * a;
                Console.WriteLine("{0} {1}", x1, x2);
            }
        }
    }

