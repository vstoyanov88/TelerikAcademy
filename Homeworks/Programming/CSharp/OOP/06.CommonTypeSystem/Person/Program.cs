//Create a class Person with two fields – name and age. Age can be left unspecified 
//(may contain null value. Override ToString() to display the information of a person and if age is not specified –
//to say so. Write a program to test this functionality.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Program
    {
        static void Main()
        {
            Person person1 = new Person("Pesho", 43);
            Console.WriteLine(person1);
            Person person2 = new Person("Ivan");
            Console.WriteLine(person2);
        }
    }
}
