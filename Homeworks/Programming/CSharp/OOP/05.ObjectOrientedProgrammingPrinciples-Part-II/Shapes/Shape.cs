using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape
    {
        protected double width { get; set; }
        protected double height { get; set; }

        public Shape(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} ", this.GetType().Name, this.CalculateSurface());
        }

        public abstract double CalculateSurface();
    }
}
