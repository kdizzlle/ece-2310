using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_inheritance
{
    class Student
    {
        //data members: attributes
        private Name studentName; //composition
        private string iD;
        private double gPA;
        //all data members are private by default but we will write it just to be clear
        //all data members - the name must start with a lowercase letter
        
        //member methods: behaviors
        public Student() //default constructor
        {
            studentName = new Name();
            iD = "1234567";
            gPA = 4;
        }
        //overloading constructors
        public Student(string fn, string ln, string id_number, double g) 
        {
            studentName = new Name(fn, ln); //composition
            iD = id_number;
            gPA = g;
        }
        public Student(string fn, string ln) 
        {
            studentName = new Name(fn, ln); //composition
            iD = "Unknown";
            gPA = 3.33;//random number since we have to give something
        }
        public Student(Name nm)
        {
            studentName = nm; //composition
            iD = "Unknown";
            gPA = 3.33;//random number since we have to give something
        }

        //properties
        public Name StudentName
        {
            get { return studentName; }
            set { studentName = value; }
        }

        //methods
        public void Study(string major)
        {
            Console.WriteLine("{0} studies {1} at Cal Poly Pomona.", studentName, major); //composition
        }
        public void Play(double time)
        {
            Console.WriteLine("{1} has played soccer for {1} hours.", studentName, time); //composition
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Name: {0}\nID: {1}\nGPA: {2}\n", studentName, iD, gPA); //composition
        }
        public override string ToString()
        {
            string outStr = "Name: " + studentName.ToString(); //composition
            outStr += " ID: " + iD + " GPA: " + gPA;
            return outStr;
        }

        //destructor
        ~Student() { }
    }
}
