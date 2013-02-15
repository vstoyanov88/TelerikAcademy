//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.

using System;

class TriangleSurface
{
    static void SideAndAltitude()
    {
        Console.WriteLine("Enter side: ");
        double side = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter Altitude");
        double altitude = double.Parse(Console.ReadLine());
        double surface = (side * altitude) / 2;
        Console.WriteLine("S={0}", surface);
    }
    static void ThreeSides()
    {
        Console.WriteLine("Enter first side: ");
        double sideA = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second side: ");
        double sideB = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter third side ");
        double sideC = double.Parse(Console.ReadLine());
        double p = (sideA + sideB + sideC) / 2;
        double surface = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        Console.WriteLine("S={0}",surface);
    }
    static void SidesAndAngle()
    {
        Console.WriteLine("Enter first side: ");
        double sideA = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second side: ");
        double sideB = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter angle: ");
        int angle = int.Parse(Console.ReadLine());
        double surface = (sideA * sideB * Math.Sin(Math.PI * angle / 180.0)) / 2;
        Console.WriteLine("S={0}",surface);
    }
    static void Main()
    {
        Console.WriteLine("How do you want to calculate trialgles area: \n 1.By side and altitude \n 2.By three sides \n 3.Two sides and angle between them");
        int n = int.Parse(Console.ReadLine());
        switch(n)
        {
            case 1: SideAndAltitude(); break;
            case 2: ThreeSides(); break;
            case 3: SidesAndAngle(); break;
            default: Console.WriteLine("Wrong entry!"); break;
        }
    }
}

