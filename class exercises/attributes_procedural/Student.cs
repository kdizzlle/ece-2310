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
        public void Study(string major)
        {
            Console.WriteLine("{0} {1} studies {2} at Cal Poly Pomona.", firstName, lastName, major);
        }
        public void Play(double time)
        {
            Console.WriteLine("{0} {1} has played the game for {2} hours.", firstName, lastName, time);
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Name: {0} {1}\nID: {2}\nGPA: {3}\n", firstName, lastName, iD, gPA);
        }
    }
}
