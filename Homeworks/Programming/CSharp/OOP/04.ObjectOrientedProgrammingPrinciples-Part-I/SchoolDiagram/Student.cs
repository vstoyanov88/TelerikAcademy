using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDiagram
{
    public class Student : Person, IComment
    {
        public int ClassNumber { get; set; }
        public string Comment { get; set; }

        public SchoolClass SchoolClass
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

       
        public Student(string name, int classNumber):base(name)
        {
            this.ClassNumber = classNumber;
        }

        public override string ToString()
        {
            StringBuilder text = new StringBuilder();
            text.AppendFormat("Student name - {0}\n class number - {1}\n",this.Name.ToString(),this.ClassNumber);
            return text.ToString();
        }

    }
}
