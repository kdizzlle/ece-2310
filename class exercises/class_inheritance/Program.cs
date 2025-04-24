using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n-----Testing Name Class-----\n");
            Name nm1 = new Name("Jane","Smith");
            Console.WriteLine("nm1={0}", nm1.ToString());
            nm1.FirstName = "Jenny";
            nm1.LastName = "Smithon";
            Console.WriteLine("nm1={0}", nm1.ToString());

            Console.WriteLine("\n-----Testing Student Class-----\n");
            const int size = 3;
            Student[] mystudent = new Student[size];
            mystudent[0] = new Student();
            mystudent[1] = new Student("Paul","Newman","222333",3.89);
            mystudent[2] = new Student(nm1);
            Console.WriteLine("Here are the students:");
            for(int i=0;i<size;i++)
            {
                Console.WriteLine("Student #{0}: \n{1}\n", i + 1, mystudent[i].ToString());
            }

            Console.Read();
        }
    }
}
