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
            //std02.DisplayInfo();
            Console.WriteLine(std02.ToString());

            std01.Study("history");
            std02.Study("EE");

            //display paul's GPA
            Console.WriteLine("Paul's GPA: "+std02.GetGPA());
            //change paul's GPA to 3.9
            std02.SetGPA(3.9);
            Console.WriteLine("Paul's new GPA: " + std02.GetGPA());

            //change linda's last name from smith to johnson
            std02.SetLN("Johnson");
            Console.WriteLine("Linda's new last name is "+std01.GetLN());

            //change std02's first name to "Paulson" using the property
            std02.FirstName = "Paulson";
            //display std02's new first name
            Console.WriteLine("Student #2 has a new first name: {0}", std02.FirstName);

            //----------------------------------------------------
            //instantiantion of an array of objects of Class Student
            const int size = 4;
            string fn, ln, id_num;
            double gpa;
            Student[] myStudent = new Student[size];
            for(int i=0; i<size; i++)
            {
                Console.WriteLine("Enter the first name of student #{0}: ", i + 1);
                fn = Console.ReadLine();
                Console.WriteLine("Enter the last name of student #{0}: ", i + 1);
                ln = Console.ReadLine();
                Console.WriteLine("Enter the ID number of student #{0}: ", i + 1);
                id_num = Console.ReadLine();
                Console.WriteLine("Enter the GPA of student #{0}: ", i + 1);
                gpa = Convert.ToDouble(Console.ReadLine());
                myStudent[i] = new Student(fn, ln, id_num, gpa);
            }
            //display the infos of the objects
            Console.WriteLine("There are {0} students in my class: ", size);
            for(int i=0; i<size; i++)
            {
                Console.WriteLine("Student #{0}: {1}",i+1,myStudent[i].ToString());
            }

            //student #1 played 2 hours of soccer
            myStudent[0].Play(2);

            //student #2's GPA changed to 3.0
            myStudent[1].SetGPA(3.0);

            //display student #3's name
            Console.WriteLine("Student 3's name is {0} {1}", myStudent[2].FirstName, myStudent[2].LastName);

            //student #4 changed her last name to Smith
            myStudent[3].LastName = "Smith";

            Console.Read();
        }
    }
}
