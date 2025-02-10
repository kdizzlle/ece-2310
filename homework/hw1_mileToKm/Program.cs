using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1_mileToKm
{
    class Program
    {
        static void Main(string[] args)
        {
            double mi, km;
            Console.WriteLine("Welcome to the mile to kilometer converter!");
            Console.WriteLine();
            Console.WriteLine("Input the distance in miles: ");
            string str_mi = Console.ReadLine();
            mi = Convert.ToDouble(str_mi);
            km = mi * 1.60934;
            Console.WriteLine(str_mi+" miles is equivalent to " + km.ToString() + " kilometers");
            Console.Read();
        }
    }
}
