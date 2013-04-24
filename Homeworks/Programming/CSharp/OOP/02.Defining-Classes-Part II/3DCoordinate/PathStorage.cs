using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DCoordinate
{
    public static class PathStorage
    {
        //methods

        public static void SavePath(Path points)
        {
            using (StreamWriter fileSave = new StreamWriter(@"../../Files/SavePath.txt")) 
            {
                foreach (Point3D point in points)
                {
                    string pointLine = string.Format("{0} {1} {2}", point.X, point.Y, point.Z);
                    fileSave.WriteLine(pointLine);
                }
                
            }
        }
        public static Path LoadPath()
        {
            Path loadPath = new Path();
            Point3D point = new Point3D();
            using (StreamReader fileLoad = new StreamReader(@"../../Files/LoadPath.txt"))
            {
                string line = "";
                while ((line = fileLoad.ReadLine()) != null)
                {
                    string[] points = line.Split(',', ' ');
                    point.X = int.Parse(points[0]);
                    point.Y = int.Parse(points[1]);
                    point.Z = int.Parse(points[2]);
                    loadPath.AddPoint(point);
                }
            }
            return loadPath;
        }
    }
}
