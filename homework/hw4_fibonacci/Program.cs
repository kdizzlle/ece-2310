using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw4_fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, nextTerm;
            for (int i = 1; i <= 30; i++)
            {
                nextTerm = n1 + n2;
                n1 = n2;
                n2 = nextTerm;
                Console.Write(n1 + " ");
                if (i % 5 == 0)
                    Console.WriteLine();
            }
            Console.Read();
        }
    }
}
