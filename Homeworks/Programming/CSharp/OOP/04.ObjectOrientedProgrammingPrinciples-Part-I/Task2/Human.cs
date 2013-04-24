using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public abstract class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        protected Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public override string ToString()
        {
            StringBuilder text = new StringBuilder();
            text.AppendFormat("{0} {1} ", this.FirstName, this.LastName);
            return text.ToString();
        }
    }
}
