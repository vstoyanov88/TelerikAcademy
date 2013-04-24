using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Person
    {
        private string name;
        private int? age;

        public Person()
        { }

        public Person(string name):this(name,null)
        {
        }

        public Person(string name, int? age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name 
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int? Age 
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public override string ToString()
        {
            StringBuilder text = new StringBuilder();
            text.AppendFormat(" Name - {0}\n Age - {1}",this.name, (this.age==null) ? "not specified":this.age.ToString());
            return text.ToString();
        }
    }
}
