using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> birthYears = new List<int>() { 1986, 1923, 1987, 1975, 1971, 1980, 1975, 1990, 1960, 1950 };

            birthYears.Sort();

            foreach (int year in birthYears)
            {
                Console.WriteLine(year);
            }

            List<string> names = new List<string>() { "Krista", "Ashley" };

            names.Add("Margaret");
            names.Add("Quinn");
            names.Add("Lawrence");
            names.Add("Richard");
            names.Add("Cameron");

            names.Sort();

            StreamWriter students = new StreamWriter("students.txt");

            using (students)
            {
                for (int i = 0; i < names.Count; i++)
                {
                    students.WriteLine(names[i]);
                }
            }

            Console.WriteLine(names.Count);
            names.Clear();
            Console.WriteLine(names.Count());

            int[] arr = new int[3];
            arr[0] = 2;
            arr[1] = 3;
            arr[2] = 5;
            List<int> list = new List<int>(arr);
            Console.WriteLine(list.Count());

            int[] arr2 = new int[3];
            arr2[0] = 3;
            arr2[1] = 4;
            arr2[2] = 5;
            List<int> list2 = arr2.ToList();
            Console.WriteLine(list2.Count);

            string[] arry = new string[3];
            arry[0] = "trash pandas";
            arry[1] = "booplesnoot";
            arry[2] = "nope rope";

            List<string> animals = arry.ToList();
            Console.WriteLine(animals.Count);

            string[] altAnimals = animals.ToArray();
            Console.WriteLine(altAnimals.Length);

        }
    }
}
