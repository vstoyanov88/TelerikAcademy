using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DCoordinate
{
    public class Path
    {
        private List<Point3D> pathHolder = new List<Point3D>();

        //prop
        public List<Point3D> PathHolder
        {
            get
            {
                return this.pathHolder;
            }
        }
        public void AddPoint(Point3D point)
        {
            pathHolder.Add(point);
        }

        public IEnumerator<Point3D> GetEnumerator()
        {
            foreach (Point3D point in pathHolder)
                yield return point;
        }
    }
}
