using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw11_student_class
{
    class Student
    {
        private string firstName;
        private string lastName;
        private string school;

        public Student()
        {
            firstName = "Unknown";
            lastName = "Name";
            school = "University";
        }
        public Student(string fn, string ln, string edu)
        {
            firstName = fn;
            lastName = ln;
            school = edu;
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string School
        {
            get { return school; }
            set { school = value; }
        }

        public override string ToString()
        {
            string outStr = firstName + " " + lastName + " attends " + school + ".\n";
            return outStr;
        }
        ~Student() { }
    }
}
