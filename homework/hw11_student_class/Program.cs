using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw11_student_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Testing Student Class-----\n");
            Student[] std = new Student[2];
            std[0] = new Student();
            std[1] = new Student("Jane", "Doe", "UCLA");
            Console.WriteLine("Instantiated Objects:");
            for(int i=0; i<2; i++)
            {
                Console.WriteLine("std[{0}]: {1}", i, std[i]);
            }
            std[0].FirstName = "Harry";
            std[0].LastName = "Styles";
            std[0].School = "Harvard";
            Console.WriteLine("Updated std[0]: " + std[0]);

            Console.WriteLine("-----Testing UnderGraduate Class-----\n");
            UnderGraduate[] ug = new UnderGraduate[2];
            ug[0] = new UnderGraduate();
            ug[1] = new UnderGraduate("Hannah", "Mayberry", "CBU", "2024", 3.2, "Nursing");
            Console.WriteLine("Instantiated Objects:");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("ug[{0}]: {1}", i, ug[i]);
            }
            ug[0].FirstName = "Tom";
            ug[0].LastName = "Holland";
            ug[0].School = "Julliard";
            ug[0].Year = "2013";
            ug[0].GPA = 3.9;
            ug[0].Major = "Acting";
            Console.WriteLine("Updated ug[0]: " + ug[0]);

            Console.WriteLine("-----Testing GraduateStudent Class-----\n");
            GraduateStudent[] gs = new GraduateStudent[2];
            gs[0] = new GraduateStudent();
            gs[1] = new GraduateStudent("Rachel", "Williams", "CSUF", "Chemistry", 2022, "Biochemistry");
            Console.WriteLine("Instantiated Objects:");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("gs[{0}]: {1}", i, gs[i]);
            }
            gs[0].FirstName = "Jon";
            gs[0].LastName = "Snow";
            gs[0].School = "Stanford";
            gs[0].Bachelors = "Science";
            gs[0].GradYear = 2012;
            gs[0].Masters = "Physics";
            Console.WriteLine("Updated gs[0]: " + gs[0]);

            Console.Read();
        }
    }
}
