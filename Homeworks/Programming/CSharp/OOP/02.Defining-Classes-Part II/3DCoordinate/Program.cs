using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DCoordinate
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Point3D.pointCount);
            Point3D point1 = new Point3D();
            Console.WriteLine(point1);
            point1.X = 1;
            point1.Y = 1;
            point1.Z = 1;
            Point3D point2 = new Point3D(1, 7, 4);
            Point3D point3 = new Point3D();
            point3 = new Point3D(1, 1, 1);
            Console.WriteLine();
            //CalculateSpace(point1, point2);
            Console.WriteLine(Point3D.StartPoint);

            Point3D point4 = new Point3D(2, 4, 4);
            Console.WriteLine(Point3D.pointCount);

            Console.WriteLine( Distance3D.CalculateDistance(point1, point2));
            Path path = new Path();
            path.AddPoint(point1);
            path.AddPoint(point2);
            foreach (Point3D point in path)
            {
                Console.WriteLine(point);
                Console.WriteLine();
            }
            PathStorage.SavePath(path);
            Console.WriteLine("loaded paths");
            Path loadPath = PathStorage.LoadPath();
            foreach (Point3D point in loadPath)
            {
                Console.WriteLine(point);
                Console.WriteLine();
            }

           
        }
    }
}
