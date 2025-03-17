using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function_overloading
{
    class Program
    {
        //input validation function
        static int GetInput(string item, int a, int b)
        {
            int x = 0;
            bool valid = true;
            do
            {
                Console.WriteLine("Please enter " + item + " : ");
                valid = int.TryParse(Console.ReadLine(), out x);
                if (!valid)
                    Console.WriteLine("Invalid! " + item + " has to be an integer! Please re-enter.");
                else if (x < a)
                    Console.WriteLine("Invalid! " + item + " cannot be less than " + a + ". Please re-enter.");
                else if (x > b)
                    Console.WriteLine("Invalid! " + item + " cannot be more than " + b + ". Please re-enter.");
                else
                    Console.WriteLine("You entered {0}",x);
            } while (!valid || x < a || x > b);
            return x;
        }
        static double GetInput(string item, double a)
        {//no upper bound
            double x = 0;
            bool valid = true;
            do
            {
                Console.WriteLine("Please enter " + item + " : ");
                valid = double.TryParse(Console.ReadLine(), out x);
                if (!valid)
                    Console.WriteLine("Invalid! " + item + " has to be an double! Please re-enter.");
                else if (x < a)
                    Console.WriteLine("Invalid! " + item + " cannot be less than " + a + ". Please re-enter.");
                else
                    Console.WriteLine("You entered {0}", x);
            } while (!valid || x < a);
            return x;
        }
        static void Main(string[] args)
        {
            int x = 10, y = 30;
            int t = What(x, ref y);
            Console.WriteLine("x={0}, y={1}, t={2}", x, y, t);
            double weight1 = GetInput("your weight in lbs", 0, 1000);
            double weight = GetInput("your weight in lbs", 0);
            //int score = GetInput("the score", 0, 100);
            Console.Read();
        }
        //gotta copy this from canvas i wasnt paying attention
    }
}
