using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Dog : Animal,ISound
    {
        public Dog(string name, int age, string sex)
            : base(name, age, sex)
        {
        }

        public Dog()
        { 
        }

        public string MakeSound()
        {
            return "bau bau";
        }
    }
}
