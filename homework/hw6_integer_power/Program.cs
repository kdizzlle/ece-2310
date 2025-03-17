using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw6_integer_power
{
    class Program
    {
        static int integerPower(int b, int exp)
        {
            int res = b;
            if (exp == 0)
                return 1;
            if (exp == 1)
                return b;
            else
            {
                for (int i = 2; i <= exp; i++)
                {
                    res = res * b;
                }
                return res;
            }
        }
        static void Main(string[] args)
        {
            int res = 0;
            int sum = 0;
            for(int i=0; i<=10; i++)
            {
                res = integerPower(2, i);
                sum += res;
            }
            Console.WriteLine("1+2+4+8+...+2^10 = "+res);
            Console.Read();
        }
    }
}
