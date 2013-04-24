using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeException
{
    public class InvalidRangeException<T> : ApplicationException
    {
        private T min { get; set; }
        private T max { get; set; }

        public InvalidRangeException(T min, T max)
        {
            this.min = min;
            this.max = max;
        }

        public override string Message
        {
            get
            {
                string result = string.Format("The value is out of the range {0} - {1}", this.min, this.max);
                return result;
            }
        }
    }
}
