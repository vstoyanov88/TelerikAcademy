using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDiagram
{
    public class Teacher : Person, IComment
    {
        public List<Discipline> ListDis { get; private set; }
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

       

        public Teacher(string name, Discipline[] listDis)
            : base(name)
        {
            this.ListDis = new List<Discipline>(listDis);
        }


        public override string ToString()
        {
            StringBuilder text = new StringBuilder();
            text.AppendFormat("Teacher - {0}\n",this.Name.ToString());
            foreach (var item in this.ListDis)
            {
                text.AppendFormat(" {0}",item.ToString());
            }
            return text.ToString();
        }
    }
}
