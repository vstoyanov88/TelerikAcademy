//Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
//Use LINQ query operators.
//Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
//Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name
//and last name in descending order. Rewrite the same with LINQ.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsNames
{
    class Program
    {
        static void Main()
        {
            Student[] studentNames = new Student[]{
                new Student {firstName = "Georgi", lastName="Mollov", age=23},
                new Student {firstName = "Galina", lastName="Grueva", age=12},
                new Student {firstName = "Dimo", lastName="Nyagolow", age=44},
                new Student {firstName ="Yana", lastName="Stoyanova", age=33},
                new Student {firstName="Hristina", lastName="Petrova",age=21}
            };
            FindName(studentNames);
            Console.WriteLine();
            FindNameAge(studentNames);
            Console.WriteLine();
            OrderNames(studentNames);
            
        }

        private static void FindName(Student[] studentNames)
        {
            var stud =
                from stundent in studentNames
                where (stundent.firstName.CompareTo(stundent.lastName) < 0)
                select stundent;
            foreach (var student in stud)
            {
                Console.WriteLine(student.firstName + " " + student.lastName);
            }
        }

        private static void FindNameAge(Student[] studentNames)
        {
            var stud =
                from student in studentNames
                where ((student.firstName.CompareTo(student.lastName) < 0) && (student.age >= 18) && (student.age <= 24))
                select student;
            foreach (var student in stud)
            {
                Console.WriteLine("{0} {1} {2}", student.firstName, student.lastName, student.age);
            }        
        }

        private static void OrderNames(Student[] studentNames)
        {
            //lambda
            var sortedStud = studentNames.OrderBy(student => student.firstName).ThenBy(student => student.lastName);
            foreach (var student in sortedStud)
            {
                Console.WriteLine(string.Format("{0} {1} {2}", student.firstName, student.lastName, student.age));
            }
            //LINQ
            //var sortedStud =
            //    from student in studentNames
            //    orderby student.firstName, student.lastName
            //    select student;
            //foreach (var student in sortedStud)
            //{
            //    Console.WriteLine("{0} {1} {2}", student.firstName, student.lastName, student.age);
            //}
        }
    }
}
