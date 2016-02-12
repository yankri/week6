using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6Projectday
{
    class MainMenu
    {
        //properties
        public List<string> Meeting { get; set; }
        public string Recorder { get; set; }

        //constructor, what it does when you declare a new one
        public MainMenu()
        {
            Meeting = new List<string>();
        }

        //declare this variables here so they can be used and assigned later 
        string recorder;
        string leader;
        string date;

        static int MainMenuChoice() //Prints the title, menu options, and takes the menu option and returns it as an int
        {
            while (true)
            {
                Console.Title = "Meeting Minutes Management System"; //changes the title of the console
                PrintMainMenu(); //calls this method to actually print the menu options

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

        public static void PrintMainMenu() //this method prints the menu options 
        {
            string[] menuOptions = { "1 - Create Meeting", "2 - View Team", "3 - Exit" };
            Console.Clear();
            Console.WriteLine("\n" + Console.Title + "\n\n");

            foreach (string option in menuOptions)
            {
                Console.WriteLine(option);
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        public static string PrintMeetingOptions() //prints the Team Meeting types and takes care of assigning the meeting type variable to be used later
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
        
        public void CreateMeeting() //this method takes in the meeting information when the create meeting menu option is selected
        {
            List<string> teams = new List<string>() { "Hunters", "Helpers", "Angels", "Demons", "All Teams" };
            Console.Clear();
            Console.WriteLine("Minutes Recorder: ");
            recorder = Console.ReadLine();

            Console.WriteLine("Meeting Leader: ");
            leader = Console.ReadLine();

            Console.WriteLine("Meeting date EX: \"MMDDYY\"");
            date = Console.ReadLine();

            string typeChoice = PrintMeetingOptions();

            MeetingTopicAndNotes meToNo = new MeetingTopicAndNotes(); //handles the meeting input and saves the meeting topic/notes to a list
            meToNo.EnterMeetingTopicNotes();

            this.Meeting = meToNo.Meeting; //makes the list used in this class equal to the list returned from the MeetingTopicAndNotes class

            MinutesWriter writer = new MinutesWriter(recorder, leader, date, typeChoice, meToNo.Meeting); //writes the information to the file 
            writer.WriteToFile();
            Console.Clear();
            PrintSummary(); //calls the method to print the meeting summary
        }

        public void PrintSummary() //prints the summary of the meeting when the user is finished entering information
        {
            string[] array;
            Console.WriteLine("Meeting recorder: ");
            Console.WriteLine(recorder);
            Console.WriteLine("Meeting leader: ");
            Console.WriteLine(leader);
            Console.WriteLine("Meeting date: ");
            Console.WriteLine(date);

            for (int i = 0; i < Meeting.Count; i++)
            {
                array = Meeting[i].Split('|');
                Console.WriteLine("Meeting topic: ");
                Console.WriteLine(array[0]);
                Console.WriteLine("Meeting Notes: ");
                Console.WriteLine(array[1]);
            }

            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey(); //makes the user press a key so that the summary isn't cleared when the main menu prints to the console again
        }

        public void Menu () //this method is basically what makes the whole program run. 
        { 
            while (true)
                {
                    bool exit = false;

                    int menuChoice = MainMenuChoice(); 
                                
                    switch (menuChoice)
                    {
                        //create meeting
                        case 1:
                            CreateMeeting();
                            break;
                        //view team
                        case 2:
                            ViewTeams viewTeams = new ViewTeams();
                            viewTeams.PrintTeams();
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
