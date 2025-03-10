using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw5_class_scores
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[26];
            string[] names = new string[26];
            string best = " ";
            int sum = 0;
            int count = 0;
            double avg = 0;
            int highest = 0;
            for (int i = 0; i < 26; i++)
            {
                Console.WriteLine("Enter the name of student " + (i + 1));
                names[i] = Console.ReadLine();
                Console.WriteLine("Enter the score of student " + (i + 1));
                bool valid_score = int.TryParse(Console.ReadLine(), out scores[i]);
                while(!valid_score || scores[i]<0 || scores[i]>100)//invalid score
                {
                    Console.WriteLine("Invlaid entry. Score must be between 0 and 100. Try again: ");
                    Console.WriteLine("Enter the score of student " + (i + 1));
                    valid_score = int.TryParse(Console.ReadLine(), out scores[i]);
                }
                sum += scores[i];
                Console.WriteLine();
            }
            avg = sum / 26.0;
            highest = scores[0];
            for(int i=0; i<26; i++)
            {
                if (scores[i] > avg)
                    count += 1;
                if (scores[i] > highest)
                {
                    highest = scores[i];
                    best = names[i];
                }
                    
            }
            Console.WriteLine();
            Console.WriteLine("The average score is " + avg);
            Console.WriteLine(count + " students were above the average.");
            Console.WriteLine(best+" had the highest score of " + highest);
            Console.Read();
        }
    }
}
