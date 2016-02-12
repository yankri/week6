using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace streamreader
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            StreamReader reader = new StreamReader("test.txt");

            string fileName = "C:\\Temp\\work\\test.txt";
            string theSameFileName = @"C:\Temp\work\test.txt";

            reader.Close();
            */


            StreamReader reader = new StreamReader(@"C:\Users\WeCanCodeIT\Documents\sample2.txt");

            using (reader)
            {
                int lineNumber = 0;

                string line = reader.ReadLine();

                while (line != null)
                {
                    lineNumber++;
                    Console.WriteLine("Line {0}: {1}", lineNumber, line);
                    line = reader.ReadLine();
                }
            }
            

        }
    }
}
