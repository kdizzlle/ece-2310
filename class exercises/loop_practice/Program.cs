using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int a = 4, b = 1;
            while (a>1)
            {
                b = b * a;
                a--;
            }

            Console.WriteLine("while loop results\n a = " + a + "\n b = " + b + "\n\n");

            a = 4;
            b = 1;
            do
            {
                b = b + 1;
                a++;
            } while (a < 4);

            Console.WriteLine("do while loop results\n a = " + a + "\n b = " + b + "\n\n");

            a = 4;
            for (b = 1; b < 4; b++)
                a *= b;

            Console.WriteLine("for loop results\n a = " + a + "\n b = " + b + "\n\n");
            Console.Read();
            */

            /*
            //write code that sums up all odd numbers from 1 to 200
            int x = 1;
            for (int y = 3; y < 200; y+=2)
            {
                x += y;
            }
                
            Console.WriteLine("The sum of all odd numbers from 1 to 200 is " + x);
            Console.Read();
            */

            //write code that sums up all odd numbers until the sum is <5000
            int sum = 0;
            int add=1;
            for (add = 1; sum < (5000 - add); add += 2)
                sum += add;

            /*do
            {
                sum += add;
                add += 2;
            } while (sum < (5000-add));*/
            
            /*while(sum<(5000-add))
            {
                sum += add;
                add += 2;
            }*/
            Console.WriteLine("1+3+5+...+"+(add-2)+" = "+sum+" < 5000");
            Console.Read();
        }
    }
}
