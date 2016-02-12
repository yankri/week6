using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Practice2
{
    
class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"C:\Users\WeCanCodeIT\Documents\Week 6\streamreader\Practice2\bin\Debug\input.txt");

            using (reader)
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (null == line)
                        continue;
                    // do something with line
                    char[] letters = line.ToCharArray();
                    StringBuilder newword = new StringBuilder();
                    foreach (char letter in letters)
                    {
                        if (Convert.ToInt32(letter) < 91 && Convert.ToInt32(letter) > 64)
                        {
                            newword.Append(Char.ToLower(letter));
                        }
                        else if (Convert.ToInt32(letter) > 96 && Convert.ToInt32(letter) < 123)
                        {
                            newword.Append(Char.ToUpper(letter));
                        }
                        else
                        {
                            newword.Append(letter);
                        }
                    }
                    Console.WriteLine(newword);
                }
        }
    }
}
