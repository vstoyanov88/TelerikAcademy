using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public abstract class Animal 
    {
        public string name { get; private set; }
        public int age { get; private set; }
        public string sex { get; private set; }

        public Animal(string name, int age, string sex)
        {
            this.name = name;
            this.age = age;
            this.sex = sex;
        }

        public Animal()
        { 
        }

        public override string ToString()
        {
            StringBuilder text = new StringBuilder();
            text.AppendFormat("{0} {1} {2} {3}",GetType().Name, this.name, this.age, this.sex);
            return text.ToString();
        }

        public static decimal GetAvaregeAge(IEnumerable<Animal> animals)
        {
            decimal count = 0;
            decimal ages = 0;
            foreach (Animal animal in animals)
            {
                count++;
                ages += animal.age;
            }
            return ages/count;
        }

    }
}
