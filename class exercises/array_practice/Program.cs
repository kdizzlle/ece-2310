using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] a = new int[5];
            Console.WriteLine("a={0}", a); //displays the object type of a
            //initializing the array
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter the value for a[{0}] please: ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            //display the array
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("a[{0}] = {1}", i, a[i]);
            }
            */
            //generate 5 random numbers between 0 and 10 as the elements of the array
            int[] b = new int[5];
            Random rn = new Random();
            for(int i=0; i<5;i++)
            {
                b[i] = rn.Next(0,11);
                Console.WriteLine("b[{0}] = {1}", i, b[i]);
            }
            //find the average of all the elements
            int sum=0;
            double avg=0;
            for(int i=0; i<5;i++)
            {
                sum += b[i];
            }
            avg = sum / 5.0;
            Console.WriteLine("The average of the elements is " + avg);
            //how many elements are above the average
            int count = 0;
            for(int i = 0; i<5; i++)
            {
                if (b[i] > avg)
                    count++;
            }
            Console.WriteLine(count+" elements are above " + avg);
            //find the largest element and it's index
            int x = 0;
            int highest = b[0];
            for(int i=0; i<5; i++)
            {
                if(b[i]>highest)
                {
                    highest = b[i];
                    x = i;
                }
            }
            //display all values == highest
            for(int i=0; i<5; i++)
            {
                if(b[i]==highest)
                {
                    Console.WriteLine("b[{0}] is the highest with value {1}.", i, highest);
                }
            }
            Console.Read();
        }
    }
}
