//We are given a school. In the school there are classes of students. Each class has a set of teachers.
//Each teacher teaches a set of disciplines. Students have name and unique class number.
//Classes have unique text identifier. Teachers have name. Disciplines have name, number of lectures 
//and number of exercises. Both teachers and students are people. Students, classes, teachers and disciplines
//could have optional comments (free text block).
//Your task is to identify the classes (in terms of  OOP) and their attributes and operations, encapsulate their fields, 
//define the class hierarchy and create a class diagram with Visual Studio.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDiagram
{
    class Program
    {
        static void Main()
        {
            Student[] students = new Student[]
            {
                new Student("Pesho",2134),
                new Student("Gosho",1234),
                new Student("Ivan",3456)
            };
            
            Discipline[] disciplines = new Discipline[]
            {
                new Discipline("math",4,4),
                new Discipline("engl",5,3),
                new Discipline("bio",20,10)
            };

            Teacher[] teachers = new Teacher[]
            {
                new Teacher("Mr Pesho",disciplines),
                new Teacher("Mr Gosho",disciplines)
            };

            SchoolClass[] classes = new SchoolClass[]
            {
                new SchoolClass(1,teachers,students)
            };

            School[] academy = new School[]
            {
                new School("Telerik Academy",classes)
            };

            Console.WriteLine("{0}",academy);
        }
    }
}
