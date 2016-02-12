using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feb_9_practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads from the console 10 students’ test scores between 0 and 100 (int). 
            //Calculate and print the sum and the average of the test scores. Use a list.  

            List<int> scores = new List<int>();
            int counter = 10;

            while (scores.Count < 11)
            {
                Console.WriteLine("Enter the student's score:");
                int score = int.Parse(Console.ReadLine());

                if (score < 0 || score > 100)
                {
                    Console.WriteLine("Please enter score between 0 and 100.");
                    continue;
                }

                scores.Add(score);
                counter--;
                if (counter == 0)
                {
                    break;
                }
                Console.WriteLine("You need to enter " + counter + " more scores.");
            }

            int sum = 0;

            foreach (int score in scores)
            {
                sum += score;
            }

            int avg = sum / scores.Count;

            Console.WriteLine("The student's average grade is: " + avg);

            Console.ReadKey();
        }

    }
}
