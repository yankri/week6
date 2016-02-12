using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"C:\Users\WeCanCodeIT\Documents\Week 6\streamreader\Practice 1\bin\Debug\Practice1.txt");

            using (reader)
            {
                //reads in each line one at a time
                string line = reader.ReadLine();
                string line2 = reader.ReadLine();
                string line3 = reader.ReadLine();

                //splits each line into an array split by commas
                string[] nouns = line.Split(',');
                string[] verbs = line2.Split(',');
                string[] prepositions = line3.Split(',');

                //one way to make the sentences
                string[] sentence = { nouns[0], verbs[0], prepositions[0] };
                string[] sentence2 = { nouns[1], verbs[1], prepositions[1] };
                string[] sentence3 = { nouns[2], verbs[2], prepositions[2] };

                //prints the properly formatted sentences
                for (int i = 0; i < nouns.Length; i++)
                {
                    Console.WriteLine(nouns[i] + " " + verbs[i] + " " + prepositions[i] + ".");
                }
            }

        }
    }
}
