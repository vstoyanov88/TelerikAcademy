//Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address
//mobile phone e-mail, course, specialty, university, faculty. Use an enumeration for the specialties, universities and faculties.
//Override the standard methods, inherited by  System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.
//Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's fields into a new object
//of type Student.
////Implement the  IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order)
////    and by social security number (as second criteria, in increasing order).


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Program
    {
        static void Main()
        {
            Student student1 = new Student("Pesho", "Pehsev", "Peshev", 12345, "Sofia", 
                89765223, "pesho@abv.bg", University.SU, Faculty.finance, Specialty.finance);
            Student student2 = new Student("Pesho", "Peshev", "Peshev", 54331, "Sofia", 
                7432487, "pesho2@abv.bg", University.TU, Faculty.IT, Specialty.IT);
            Console.WriteLine(student1);
            Console.WriteLine();
            Console.WriteLine(student2);
            Console.WriteLine(student1 != student2);
            Console.WriteLine(student1 == student2);
            Console.WriteLine(student1.GetHashCode());
            Console.WriteLine();

            Student student3 = (Student)student1.Clone();
            Console.WriteLine(student3);
            Console.WriteLine(student1.ComparerTo(student2));
            Console.WriteLine(student1.ComparerTo(student3));
        }
    }
}
