using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functions_practice
{
    class Program
    {
        //user-defined functions
        static int Larger(int n1, int n2)
        {
            if (n1 >= n2) return n1;
            else return n2;
        }
        static bool IsEven(int n)
        {
            if (n % 2 == 0) return true;
            else return false;
        }
        static double DblRan(double a, double b)
        {
            Random rn = new Random();
            return a + (b - a) * rn.NextDouble();
        }
        static void Hyp(double a, double b)
        {//hypotenuse of a triangle rounded to 3 dec places and display
            double c = Math.Sqrt(a * a + b * b);
            Console.WriteLine("The hypotenuse is " + Math.Round(c, 3));
        }
        //input validation function
        static int Validate(int a, int x)
        {
            //i dont remember what she told us to do for this oops
        }
        static void Main(string[] args)
        {
            Hyp(3.5, 4.5);
            Console.WriteLine("The bigger number is {0}", Larger(15, 20));
            int k = -11;
            if (IsEven(k))
                Console.WriteLine("{0} is even.", k);
            else
                Console.WriteLine("{0} is odd.", k);
            //generate a random number between 10 and 20
            double x = 0;
            x = DblRan(10, 20);
            Console.WriteLine(x);
            //tried to do a loop to generate 10 random numbers, but didn't work
            //calling the random function too quickly, so it doesn't make a new number yet
            Console.Read();
        }
    }
}
