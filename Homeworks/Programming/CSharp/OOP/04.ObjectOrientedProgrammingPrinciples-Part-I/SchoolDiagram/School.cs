using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDiagram
{
    public class School
    {
        public string Name { get; private set; }
        public List<SchoolClass> ListClasses { get; private set; }

        public School(string name, SchoolClass[] listClasses)
        {
            this.Name = name;
            this.ListClasses = new List<SchoolClass>(listClasses);
        }

        public override string ToString()
        {
            StringBuilder text = new StringBuilder();
            text.AppendFormat("School name - {0}\n", this.Name.ToString());
            foreach (var item in ListClasses)
            {
                text.AppendFormat(" {0} ", item.ToString());
            }
            return text.ToString();
        }
    }
}
