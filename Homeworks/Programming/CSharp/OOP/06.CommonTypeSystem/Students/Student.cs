using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    public class Student : IClonable, IComparable<Student>
    {
        private string firstName;
        private string secondName;
        private string lastName;
        private int ssn;
        private string adrress;
        private int phoneNumber;
        private string email;
        private University university;
        private Faculty faculty;
        private Specialty specialty;

        public Student()
        { }

        public Student(string firstName, string secondName, string lastName, int ssn, string adrress, int phoneNumber, string email,
            University university, Faculty faculty, Specialty specialty)
        {
            this.firstName = firstName;
            this.secondName = secondName;
            this.lastName = lastName;
            this.ssn = ssn;
            this.adrress = adrress;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.university = university;
            this.faculty = faculty;
            this.specialty = specialty;
        }

        public string FirstName 
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string SecondName 
        {
            get { return this.secondName; }
            set { this.secondName = value; }
        }

        public string  LastName 
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public int SSN 
        {
            get { return this.ssn; }
            set { this.ssn = value; }
        }

        public string Adrress 
        {
            get { return this.adrress; }
            set { this.adrress = value; }
        }

        public int PhoneNumber 
        {
            get { return this.phoneNumber; }
            set { this.phoneNumber = value; }
        }

        public string Email 
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public University University 
        {
            get { return this.university; }
            set { this.university = value; }
        }

        public override string ToString()
        {
            StringBuilder text = new StringBuilder();
            text.AppendFormat(" Name - {0} {1} {2}\n ssn - {3}\n Adress, phone, mail - {4}, {5}, {6}\n University, faculty, specialty - {7}, {8}, {9}",
                this.firstName, this.secondName, this.lastName, this.ssn, this.adrress, this.phoneNumber, this.email, this.university, this.faculty, this.specialty);
            return text.ToString();
        }

        public override bool Equals(object param)
        {
            Student student = param as Student;
            if (this.ssn == student.ssn)
            {
                return true;
            }
            return false;
        }

        public static bool operator ==(Student student1, Student student2)
        {
            return Student.Equals(student1, student2);
        }

        public static bool operator !=(Student student1, Student student2)
        {
            return !(Student.Equals(student1,student2));
        }

        public override int GetHashCode()
        {
            return lastName.GetHashCode() ^ ssn.GetHashCode();
        }

        public Student Clone()
        {
            Student clone = new Student(this.firstName, this.secondName, this.lastName, this.ssn, this.adrress,
                 this.phoneNumber, this.email, this.university, this.faculty, this.specialty);
            return clone;
        }


        public int ComparerTo(Student student1)
        {
            if (this.firstName != student1.firstName)
            {
                return this.firstName.CompareTo(student1.firstName);
            }
            if (this.secondName != student1.secondName)
            {
                return this.secondName.CompareTo(student1.secondName);
            }
            if (this.lastName != student1.lastName)
            {
                return this.lastName.CompareTo(student1.lastName);
            }
            return this.ssn.CompareTo(student1.ssn);
        }
    }
}
