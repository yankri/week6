using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6Projectday
{
    class MinutesWriter
    {
        //properties
        public string Recorder { get; set; }
        public string Leader { get; set; }
        public string Date { get; set; }
        public string TypeChoice { get; set; }
        public List<string> Meeting { get; set; }

        private static int noDateFileCounter = 1;
        private static int fileExistsCounter = 1;

        //constructor, this is what happens when you make a new isntance of the class
        public MinutesWriter(string recorder, string leader, string date, string typeChoice, List<string> meeting)
        {
            Recorder = recorder;
            Leader = leader;

            if (string.IsNullOrWhiteSpace(date) == true) //Makes the date 000000 if nothing is entered for the date so it doesn't break the program
            {
                date = "NoDateEntered" + noDateFileCounter;
                Date = date;
                noDateFileCounter++; //counts up each time it's used
            }
            else //otherwise Date becomes the date that is entered
            {
                Date = date;
            }

            TypeChoice = typeChoice;
            Meeting = meeting;
        }

        public void WriteToFile() //This method takes care of the actual file writing
        {
            string fileName = "Meeting" + Date;

            while (File.Exists(fileName + ".txt") == true)
            {
                fileName = fileName + "(" + fileExistsCounter + ")";
                fileExistsCounter++;
            }

            fileName = fileName + ".txt";

            StreamWriter writer = new StreamWriter(fileName);

            List<string> header = new List<string>() { "Family Business, L.L.C.", "101 Main Street", "Lawrence, KS 66044", "-----------------------", "\"Meeting Minutes\"", "-----------------------" };

            using (writer)
            {
                for (int j = 0; j < header.Count; j++)
                {
                    writer.WriteLine(header[j]);
                }

                //writes the meeting information to the file
                writer.WriteLine();
                writer.WriteLine("Meeting Recorder: ");
                writer.WriteLine(Recorder);
                writer.WriteLine();
                writer.WriteLine("Meeting Leader: ");
                writer.WriteLine(Leader);
                writer.WriteLine();
                writer.WriteLine("Meeting Date: ");
                writer.WriteLine(Date);
                writer.WriteLine();
                writer.WriteLine("Meeting Type: ");
                writer.WriteLine(TypeChoice);
                writer.WriteLine();

                for (int i = 0; i < Meeting.Count; i++) //loops through the list where the meeting topic and notes are stored and writes them to the file
                {
                    string[] splits = Meeting[i].Split('|');
                    string topic = splits[0];
                    string notes = splits[1];
                    writer.WriteLine("Meeting Topic: ");
                    writer.WriteLine(topic);
                    writer.WriteLine();
                    writer.WriteLine("Meeting Notes: ");
                    writer.WriteLine(notes);
                    writer.WriteLine();
                }
            }
        }
    }
}
