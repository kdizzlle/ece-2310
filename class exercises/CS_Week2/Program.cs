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
            Console.WriteLine("Hello World!");
            Console.WriteLine();
            Console.WriteLine("Welcome to ECE2310.02!");
            Console.WriteLine("-----------------------------------\n");
            Console.WriteLine("Welcome to my temperature converter(F-->C)\n");
            Console.Write("What is the temperature today, please?");
            double C, F;
            string str_F = Console.ReadLine();
            F = Convert.ToDouble(str_F);
            C = (F - 32) * 5 / 9;
            Console.WriteLine("It would be "+C.ToString()+" degrees in C.");
            Console.WriteLine("It would be " + Math.Round(C, 2) + " degrees in C rounded.");
            Console.Read();
        }
    }
}
