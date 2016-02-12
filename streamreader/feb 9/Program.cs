using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace feb_9
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter writer = new StreamWriter("Answers.txt");

            using (writer)
            {
                writer.WriteLine("Hello World");
            }

            StreamWriter writer2 = new StreamWriter("numbers.txt");

            using (writer2)
            {
                for (int i = 1; i <= 20; i++)
                {
                    writer2.WriteLine();
                }
            }

            string fileName = "numbers.txt";
            try
            {
                StreamReader reader = new StreamReader(fileName);
                Console.WriteLine("File {0} successfully opened.", fileName);
                Console.WriteLine("File contents:");
                using (reader)
                {
                    Console.WriteLine(reader.ReadToEnd());
                }
            }
            catch (FileNotFoundException)
            {
                Console.Error.WriteLine("Can not find file {0}.", fileName);
            }
            catch (DirectoryNotFoundException)
            {
                Console.Error.WriteLine("Can not find file {0}.", fileName);
            }
            catch (IOException)
            {
                Console.Error.WriteLine("Cannot open the file {0}.", fileName);
            }

        }
    }
}
