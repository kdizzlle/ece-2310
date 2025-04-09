using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attributes_procedural
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiation of objects of Class Student using constructors
            //Student std01 = new Student();
            //Student std02 = new Student();
            //both use the default constructor

            //now using overloaded constructors
            Student std01 = new Student("Linda", "Smith", "0011123", 3.65);
            Student std02 = new Student("Paul", "Ryan", "9966000", 3.9);
            //now we can specify the values for the attributes

            //display them
            Console.WriteLine("Student #1\n_____________________");
            std01.DisplayInfo();
            Console.WriteLine("Student #2\n_____________________");
            std02.DisplayInfo();

            std01.Study("history");
            std02.Study("EE");

            Console.Read();
        }
    }
}
