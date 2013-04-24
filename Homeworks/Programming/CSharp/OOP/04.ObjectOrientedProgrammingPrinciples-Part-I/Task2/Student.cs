using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Student : Human
    {
        public double Grade { get; private set; }

        public Student(string firstName, string lastName, double grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public override string ToString()
        {
            StringBuilder text = new StringBuilder();
            text.AppendFormat("{0} {1} {2} ", this.FirstName.ToString(), this.LastName.ToString(), this.Grade.ToString());
            return text.ToString();
        }
    }
}
