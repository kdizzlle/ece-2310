using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midterm
{
    class Program
    {
        //user-defined functions
        static int[] GetRandom(int N, int a, int b)
        {
            int[] arr = new int[N];
            Random rand = new Random();
            for (int i=0; i<N; i++)
            {
                arr[i] = rand.Next(a, b + 1);
            }
            return arr;
        }

        static int Smallest(int[] Y, ref int pos)
        {
            int N = Y.Length;
            pos = 0;
            int small = Y[0];//set current smallest to first element in array
            for(int i=0; i<N; i++)
            {
                if(Y[i]<small)
                {
                    small = Y[i];
                    pos = i;
                }
            }
            return small;
        }
        static int Input(string prompt, int a)
        {
            bool valid = true;
            int x = 0;
            do
            {
                Console.WriteLine(prompt);
                valid = int.TryParse(Console.ReadLine(), out x);
                if (!valid || x<a)
                    Console.WriteLine("Invalid input. Please re-enter.");
            } while (!valid || x<a);
            return x;
        }
        //main program
        static void Main(string[] args)
        {
            int size;
            string prompt = "How many random numbers are there?: ";
            size = Input(prompt, 1);
            string prompt2 = "What is the lower bound?: ";
            string prompt3 = "what is the upper bound?: ";
            int lower = Input(prompt2, 0);
            int upper = Input(prompt3, 0);

            int[] array = GetRandom(size, lower, upper);
            Console.WriteLine("The random numbers are:\nPosition\tNumber\n");
            for(int i=0; i<size; i++)
                Console.WriteLine("    "+(i + 1)+ "\t\t  " + array[i]);
            int position = 0;
            ref int place = ref position;
            int smallest = Smallest(array, ref place);
            Console.WriteLine("The smallest among them is {0} at position {1}", smallest.ToString(), (position+1).ToString());
            Console.Read();
        }
    }
}
