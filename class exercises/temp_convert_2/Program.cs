using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Week2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my temperature converter!\n");
            Console.WriteLine("Enter 1 for F->C and 2 for C->F\n");
            string unit_str = Console.ReadLine();
            int unit = Convert.ToInt16(unit_str);
            double C, F;
            string str_F;
            string str_C;
            if (unit == 1)
            {
                Console.Write("What is the temperature in F?");
                str_F = Console.ReadLine();
                F = Convert.ToDouble(str_F);
                C = (F - 32) * 5 / 9;
                Console.WriteLine("It would be " + Math.Round(C, 2) + " degrees in C.");
            }
            if (unit == 2)
            {
                Console.Write("What is the temperature in C?");
                str_C = Console.ReadLine();
                C = Convert.ToDouble(str_C);
                F = ((C * 9)/5) + 32;
                Console.WriteLine("It would be " + Math.Round(F, 2) + " degrees in F.");
            }

            Console.Read();
        }
    }
}