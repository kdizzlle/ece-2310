using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accumulation_algorithm_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            double sum = 0;
            for(int i=0; i<=10; i++)
            {
                sum += Math.Pow(2,i);
            }
            Console.WriteLine("2^10 + 2^9 + ... + 4 + 2 + 1 = " + sum);
            Console.Read();
            */
            /*
            //instantiating an object of class Random
            Random rnobj = new Random();
            //use methods Next of class Random to generate random integers
            int x;
            for (int i = 1; i<11; i++)
            {
                //this does any random number with no bounds
                //x = rnobj.Next(); //here we use the object instead of the class
                //this does any random number within specified bounds
                x = rnobj.Next(60,71);
                Console.WriteLine(x.ToString());
            }
            Console.Read();
            */
            //display the average score of the class
            Random rnobj = new Random();
            double sum, avg;
            int size;
            Console.WriteLine("How many students are in the class?\n");
            size = Console.Read();
            for(int i=0; i<size; i++)
            {
                sum += rnobj.NextDouble(0, 101);
            }
            avg = sum / size;
            Console.WriteLine("The sum of all the scores is " + sum);
            Console.WriteLine("The average is " + avg);


            /*
            //randomly generated BMI
            Random rnobj = new Random();
            double y;
            for(int i=1;i<11;i++)
            {
                y = 15.2 + (31.801 - 15.2) * rnobj.NextDouble();
                Console.WriteLine(Math.Round(y, 1).ToString());
            }
            Console.Read();
            */
        }
    }
}
