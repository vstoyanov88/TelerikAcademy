using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDiagram
{
    public class SchoolClass : IComment
    {
        public int SchoolClassID { get; private set; }
        public List<Teacher> Teachers { get; private set; }
        public List<Student> Students { get; private set; }
        public string Comment { get; set; }

        public School School
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }


        public SchoolClass(int schoolClassID,Teacher[] teachers, Student[] students)
        {
            this.SchoolClassID = schoolClassID;
            this.Teachers = new List<Teacher>(teachers);
            this.Students = new List<Student>(students);
        }

        public override string ToString()
        {
            StringBuilder text = new StringBuilder();
            text.AppendFormat("Class number - {0}\n", this.SchoolClassID.ToString());
            foreach (var teacher in Teachers)
            {
                text.AppendFormat(" {0} ",teacher.ToString());
            }
            foreach (var student in Students)
            {
                text.AppendFormat(" {0} ", student.ToString());
            }
            return text.ToString();
        }
    }
}
