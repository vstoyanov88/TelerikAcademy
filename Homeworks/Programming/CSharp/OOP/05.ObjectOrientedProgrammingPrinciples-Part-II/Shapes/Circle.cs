using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : Shape
    {
        private double radius { get; set; }
        public Circle(double radius)
            : base(radius,radius)
        {
            this.radius = radius;
        }

        public override double CalculateSurface()
        {
            double surface = radius*radius*3.14;
            return surface;
        }
    }
}
