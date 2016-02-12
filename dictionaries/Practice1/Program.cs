using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    class Program
    {
        public static void AddToDictionary(Dictionary<string, int> people, string input)
        {
            string[] splits = input.Split(' ');

            people.Add(splits[0], int.Parse(splits[1]));
        }

        static void Main(string[] args)
        {
            bool runner = false;
            bool runner2 = false;
            Dictionary<string, int> people = new Dictionary<string, int>();

            while (runner == false)
            {
                Console.WriteLine("Enter a name and an age separated by a space. Ex: \"John 34\".");
                string input = Console.ReadLine().ToLower();

                if (string.IsNullOrWhiteSpace(input) == false)
                {
                    AddToDictionary(people, input);
                }
                else
                {
                    runner = true;
                }
            }

            while (runner2 == false)
            {
                Console.WriteLine("Enter a name to get their age:");
                string input = Console.ReadLine().ToLower();

                if (people.ContainsKey(input))
                {
                    Console.WriteLine(people[input]);
                }
                else if (string.IsNullOrWhiteSpace(input) == true)
                {
                    Console.WriteLine("Quitting...");
                    runner2 = true;
                }
                else
                {
                    Console.WriteLine("Does not exist.");
                    continue;
                }
            }

        }
    }
}
