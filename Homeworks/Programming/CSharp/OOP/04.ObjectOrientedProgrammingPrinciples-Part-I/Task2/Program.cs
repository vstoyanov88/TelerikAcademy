//Define abstract class Human with first name and last name. Define new class Student which is derived
//from Human and has new field – grade. Define class Worker derived from Human with new property
//WeekSalary and WorkHoursPerDay and method MoneyPerHour() that returns money earned by hour by the worker.
//Define the proper constructors and properties for this hierarchy. Initialize a list of 10 students 
//and sort them by grade in ascending order (use LINQ or OrderBy() extension method). 
//Initialize a list of 10 workers and sort them by money per hour in descending order. Merge the lists and 
//sort them by first name and last name.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Pesho", "Peshev", 4.50));
            students.Add(new Student("Ivan", "Peshev", 6));
            students.Add(new Student("Ivan", "Ivanov", 3.75));
            students.Add(new Student("Georgi", "Georgiev", 4.666666));
            students.Add(new Student("Dimitur", "Aleksandrov", 5.333333));
            students.Add(new Student("Mariq", "Aleksieva", 2));
            students.Add(new Student("Mitko", "Dimitrov", 5.50));
            students.Add(new Student("Petur", "Dobrev", 3.50));
            students.Add(new Student("Georgi", "Stoyanov", 4.55));
            students.Add(new Student("Pesho", "Georgiev", 4.45));

            students=students.OrderBy(student => student.Grade).ToList();
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();

            List<Worker> workers = new List<Worker>()
            {
            new Worker("Gosho", "Aleksandrov", 700, 8),
            new Worker("Petur", "Aleksandrov", 650, 8),
            new Worker("Dimitur", "Dimitrov", 820, 9),
            new Worker("hAsen", "7mi", 680.93, 8),
            new Worker("Stoyan", "Aleksandrov", 600.74, 8),
            new Worker("Pesho", "Dobrev", 710.10, 8),
            new Worker("Angel", "Malinov", 672.30, 8),
            new Worker("Goce", "Delchev", 550.55, 6),
            new Worker("Ivan", "Petrov", 701.32, 8),
            new Worker("Petur", "Ivanov", 880.23, 8.5),
            new Worker("Kiril","Georgiev",600.50,8)
            };

            workers = workers.OrderByDescending(worker => worker.MoneyPerHour()).ToList();
            foreach (var worker in workers)
            {
                Console.WriteLine(worker);
            }
            Console.WriteLine();

            var mergeList = students.Union<Human>(workers).ToList();
            mergeList = mergeList.OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ToList();
            foreach (var item in mergeList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
