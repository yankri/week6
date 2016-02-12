using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    class Program
    {
        public static void AddToDictionary(Dictionary<int, string> books, string input)
        {
            string[] splits = input.Split(',');

            books.Add(int.Parse(splits[0]), splits[1]);
        }

        static void Main(string[] args)
        {
            Dictionary<int, string> books = new Dictionary<int, string>();

            while (true)
            {
                Console.WriteLine("Enter the book's ID number and title separated by a space. \nEx: \"345,Harry Potter\".");
                string input = Console.ReadLine();


                if (string.IsNullOrWhiteSpace(input) == false)
                {
                    AddToDictionary(books, input);
                }
                else
                { 
                    foreach (KeyValuePair<int, string> pair in books)
                    {
                        Console.WriteLine("Book ID: " + pair.Key + ", Title: " + pair.Value);
                    }
                    break;

                }
            }
        }
    }
}
