using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    public class Call
    {
        //fields
        private DateTime dateTime;
        private int number;
        private int seconds;
        //constructors
        public Call()
        {
        }

        public Call(DateTime dateTime, int number, int seconds)
        {
            this.dateTime = dateTime;
            this.number = number;
            this.seconds = seconds;
        }
        //properties
        public DateTime DateTime  
        {
            get { return this.dateTime; }
            set { this.dateTime = value; }
        }

        public int Number
        {
            get { return this.number; }
            set { this.number = value; }
        }

        public int Seconds 
        {
            get { return this.seconds; }
            set { this.seconds = value; }
        }
    }
}
