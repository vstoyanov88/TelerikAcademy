using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDiagram
{
    public class Discipline : IComment
    {
        public string Name { get; private set; }
        public int LecturesNumber { get; private set; }
        public int ExercisesNumber { get; private set; }
        public string Comment { get; set; }

        public Teacher Teacher
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }


        public Discipline(string name, int lecturesNumber, int exercisesNumber)
        {
            this.Name = name;
            this.LecturesNumber = lecturesNumber;
            this.ExercisesNumber = exercisesNumber;
        }

        public Discipline()
        {
        }

        public override string ToString()
        {
            StringBuilder text = new StringBuilder();
            text.AppendFormat("discipline - {0};number of lectures - {1};number of exercises - {2}\n",this.Name.ToString(), this.LecturesNumber, this.ExercisesNumber);
            return text.ToString();
        }

    }
}
