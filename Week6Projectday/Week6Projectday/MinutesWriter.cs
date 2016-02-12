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
        public string Recorder { get; set; }
        public string Leader { get; set; }
        public string Date { get; set; }
        public string TypeChoice { get; set; }
        public List<string> Meeting { get; set; }

        public MinutesWriter(string recorder, string leader, string date, string typeChoice, List<string> meeting)
        {
            Recorder = recorder;
            Leader = leader;
            Date = date;
            TypeChoice = typeChoice;
            Meeting = meeting;
        }

        public void WriteToFile()
        {
            string fileName = "Meeting" + Date + ".txt";

            StreamWriter writer = new StreamWriter(fileName);

            List<string> header = new List<string>() { "Family Business, L.L.C.", "101 Main Street", "Lawrence, KS 66044", "-----------------------", "\"Meeting Minutes\"", "-----------------------" };

            using (writer)
            {
                for (int j = 0; j < header.Count; j++)
                {
                    writer.WriteLine(header[j]);
                }

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

                for (int i = 0; i < Meeting.Count; i++)
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
