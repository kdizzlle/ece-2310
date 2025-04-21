using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attributes_procedural
{
    class Student
    {
        //data members: attributes
        private string firstName;
        private string lastName;
        private string iD;
        private double gPA;
        //all data members are private by default but we will write it just to be clear
        //all data members - the name must start with a lowercase letter
        
        //member methods: behaviors
        public Student() //default constructor
        {
            firstName = "Kelly";
            lastName = "Williams";
            iD = "1234567";
            gPA = 4;
        }
        public Student(string fn, string ln, string id_number, double g) //overloaded constructor
        {
            firstName = fn;
            lastName = ln;
            iD = id_number;
            gPA = g;
        }
        public Student(string fn, string ln) //overloaded constructor
        {
            firstName = fn;
            lastName = ln;
            iD = "Unknown";
            gPA = 3.33;//random number since we have to give something
        }
        //properties
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
        //accessors, or getters
        public double GetGPA()
        {
            return gPA;
        }
        public string GetLN()
        {
            return lastName;
        }
        //mutators, or setters
        public void SetGPA(double g)
        {
            gPA = g;
        }
        public void SetLN(string last)
        {
            lastName = last;
        }
        //methods
        public void Study(string major)
        {
            Console.WriteLine("{0} {1} studies {2} at Cal Poly Pomona.", firstName, lastName, major);
        }
        public void Play(double time)
        {
            Console.WriteLine("{0} {1} has played soccer for {2} hours.", firstName, lastName, time);
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Name: {0} {1}\nID: {2}\nGPA: {3}\n", firstName, lastName, iD, gPA);
        }
        public override string ToString()
        {
            string outStr = "Name: " + firstName + " " + lastName;
            outStr += " ID: " + iD + " GPA: " + gPA;
            return outStr;
        }
    }
}
