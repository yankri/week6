using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6Projectday
{
    class Program
    {
        static int MainMenu ()
        {
            while (true)
            {
                Console.Title = "Meeting Minutes Management System";
                PrintMainMenu();

                string choice = Console.ReadLine();
                int menuChoice = 0;
                bool result = int.TryParse(choice, out menuChoice);

                if (result == true)
                {
                    return menuChoice;
                }
                else
                {
                    continue;
                }
            }
        }
        static void PrintMainMenu()
        {
            string[] menuOptions = { "1 - Create Meeting", "2 - View Team", "3 - Exit" };

            Console.WriteLine("\n" + Console.Title + "\n\n");

            foreach (string option in menuOptions)
            {
                Console.WriteLine(option);
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        static string PrintMeetingOptions()
        {
            List<string> teams = new List<string>() { "Hunters", "Helpers", "Angels", "Demons", "All Teams" };

            Console.WriteLine("Enter the Meeting Type: ");
            int counter = 1;

            for (int i = 0; i < teams.Count; i++)
            {
                Console.WriteLine(counter + " - " + teams[i]);
                counter++;
            }
            int type = int.Parse(Console.ReadLine());
            string typeChoice = "";

            switch (type)
            {
                case 1:
                    typeChoice = teams[0];
                    return typeChoice;
                case 2:
                    typeChoice = teams[1];
                    return typeChoice;
                case 3:
                    typeChoice = teams[2];
                    return typeChoice;
                case 4:
                    typeChoice = teams[3];
                    return typeChoice;
                case 5:
                    typeChoice = teams[4];
                    return typeChoice;
                default:
                    typeChoice = teams[4];
                    return typeChoice;
            }
        }

        static void CreateMeeting ()
        {
            List<string> teams = new List<string>() { "Hunters", "Helpers", "Angels", "Demons", "All Teams" };

            Console.WriteLine("Minutes Recorder: ");
            string recorder = Console.ReadLine();

            Console.WriteLine("Meeting Leader: ");
            string leader = Console.ReadLine();

            Console.WriteLine("Meeting date EX: \"MMDDYY\"");
            string date = Console.ReadLine();

            string typeChoice = PrintMeetingOptions();

            MeetingTopicAndNotes meToNo = new MeetingTopicAndNotes();
            meToNo.EnterMeetingTopicNotes();

            MinutesWriter writer = new MinutesWriter(recorder, leader, date, typeChoice, meToNo.Meeting); 
            writer.WriteToFile();

            PrintSummary(meToNo.Meeting);
        }

        static void PrintSummary(List<string> meeting)
        {
            string[] array;

            for (int i = 0; i < meeting.Count; i++)
            {
                array = meeting[i].Split('|');
                Console.WriteLine("Meeting topic: ");
                Console.WriteLine(array[0]);
                Console.WriteLine("Meeting Notes: ");
                Console.WriteLine(array[1]);

            }
        }

        


        
        static void Main(string[] args)
        {
            while (true)
            {
                bool exit = false;

                int menuChoice = MainMenu(); 
                                
                switch (menuChoice)
                {
                    //create meeting
                    case 1:
                        CreateMeeting();
                        break;
                    //view team
                    case 2:
                        break;
                    //Exit
                    case 3:
                        Console.WriteLine("\nGoodbye!\n");
                        exit = true;
                        break;
                    default:
                        continue;
                }

                if (exit == true)
                {
                    break;
                }
            }

        }
    }
}
