using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionaries
{
    class Program
    {
        public static Dictionary<string, int> AddToDictionary (string name, int age)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            dictionary.Add(name, age);

            return dictionary;
        }

        static void Main(string[] args)
        {
            /*
            Dictionary<string, int> people = new Dictionary<string, int>();

            people.Add("John", 21);
            people.Add("Laura", 90);
            people.Add("Bob", 56);
            people.Add("Mary", 34);
            */
            Dictionary<string, int> zoo = new Dictionary<string, int>()
            {
                {"Lions", 7},
                {"Elephants", 4 },
                {"Dragons", 4 },
                {"wolves", 12 }
            };

            if (zoo.ContainsKey("Lions"))
            {
                int value = zoo["Lions"];
                Console.WriteLine(value);
            }

            int value2;
            if (zoo.TryGetValue("Wolves", out value2))
            {
                Console.WriteLine(value2);
            }

            foreach (KeyValuePair<string, int> pair in zoo)
            {
                Console.WriteLine("Key: " + pair.Key + ",Value: " + pair.Value);
            }

            foreach (string key in zoo.Keys)
            {
                Console.WriteLine("Key: " + key);
            }

            foreach (int value in zoo.Values)
            {
                Console.WriteLine("Values: " + value);
            }

            Dictionary<string, Dictionary<string, int>> people = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> location = new Dictionary<string, int>() { { "Krista", 29 } };
            people.Add("Krista", AddToDictionary("Cleveland", 29));
            people.Add("Krista", location);

        }
    }
}
