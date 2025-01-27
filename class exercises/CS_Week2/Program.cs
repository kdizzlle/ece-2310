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
            F = Convert.ToDouble(Console.ReadLine());
            
            C = (F - 32) * 5 / 9;
            Console.WriteLine("So it is "+F.ToString()+" degrees in F, which is equal to "+C.ToString()+" in degrees C.");
            Console.Read();
        }
    }
}
