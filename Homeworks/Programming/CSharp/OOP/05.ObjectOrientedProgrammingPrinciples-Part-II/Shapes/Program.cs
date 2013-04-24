﻿//Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height. 
//Define two new classes Triangle and Rectangle that implement the virtual method and return the surface 
//of the figure (height*width for rectangle and height*width/2 for triangle). Define class Circle and
//suitable constructor so that at initialization height must be kept equal to width and implement 
//the CalculateSurface() method. Write a program that tests the behavior of  the CalculateSurface() method 
//for different shapes (Circle, Rectangle, Triangle) stored in an array.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main()
        {
            Shape[] shapes = new Shape[]
            {
                new Triangle(3,4),
                new Rectangle(3,4),
                new Circle(3)
            };
            foreach (Shape item in shapes)
            {
                Console.WriteLine(item);
            }
        }
    }
}
