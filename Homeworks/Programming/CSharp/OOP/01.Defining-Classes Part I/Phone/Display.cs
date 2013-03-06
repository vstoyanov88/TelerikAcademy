using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    public class Display
    {
        //fields
        private double size;
        private int colors;
        //constructors
        public Display()
        {
        }
        
        public Display(double size, int colors)
        {
            this.size = size;
            this.colors = colors;
        }
        //properties
        public double Size 
        {
            get { return this.size; }
            set { this.size = value; }
        }

        public int Colors 
        {
            get { return this.colors; }
            set { this.colors = value; }
        }
    }
}
