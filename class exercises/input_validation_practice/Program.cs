using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace input_validation_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
            Console.Write("Enter score: ");
            string str_score = Console.ReadLine();
            bool valid = int.TryParse(str_score, out score);
            while(!(valid && score<=100 && score>=0)) //invalid
            {
                Console.WriteLine("Invalid! Please re-enter the score: ");
                str_score = Console.ReadLine();
                valid = int.TryParse(str_score, out score);
            }
            if (valid && score<=100 && score>=0) //valid
            {
                Console.WriteLine("Your score is {0}", score);
                Console.Read();
            }
            else //invalid
            {
                if (!valid)
                    Console.WriteLine("Invalid. Score has to be an integer number. Please re-enter.");
                else if (score > 100)
                    Console.WriteLine("Invalid. Score cannot be over 100. Please re-enter.");
                else
                    Console.WriteLine("Invalid. Score cannot be less than zero. Please re-enter.");
            }
        }
    }
}
