using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6Projectday
{
    //print out each team 
    //print out everyone Name (Team)

    class ViewTeams
    {
        Dictionary<string, string> TeamDictionary = new Dictionary<string, string>() //Dictionary contains all team information
            {
                {"Sam Winchester", "Hunters"},
                {"Dean Winchester", "Hunters"},
                {"John Winchester", "Hunters"},
                {"Bobby Singer", "Helpers"},
                {"Garth Fitzgerald IV", "Helpers"},
                {"Ellen Harville", "Helpers"},
                {"Castiel", "Angels"},
                {"Gabriel", "Angels"},
                {"Gadreel", "Angels"},
                {"Crowley", "Demons"},
                {"Azazel", "Demons"},
                {"Ruby", "Demons"}
            };

        List<string> teams = new List<string>() { "Hunters", "Helpers", "Angels", "Demons", "All Teams" }; //team names

        public void PrintTeams () //this method prints the team options in the menus and takes the input from the user and processes it
        {
            int choice = 0;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter a number to select a team: ");
                int counter = 1;

                for (int i = 0; i < teams.Count; i++)
                {
                    Console.WriteLine(counter + " - " + teams[i]);
                    counter++;
                }
                string input = Console.ReadLine();
                bool result = int.TryParse(input, out choice); //try parse to make sure its a number being entered

                if (result == true)
                {
                    break;
                }
                else
                {
                    continue;
                }
            }

            string teamName = "";

            switch (choice) //assigns the variable teamName with the team from the List containing the names of teams, uses the GetTeamMembers method to print out the members from the selected team 
            {
                case 1:
                    teamName = teams[0];
                    GetTeamMembers(teamName);
                    break;
                case 2:
                    teamName = teams[1];
                    GetTeamMembers(teamName);
                    break;
                case 3:
                    teamName = teams[2];
                    GetTeamMembers(teamName);
                    break;
                case 4:
                    teamName = teams[3];
                    GetTeamMembers(teamName);
                    break;
                case 5:
                    teamName = teams[4];
                    GetAllPeople();
                    break;
                default: //default prints everyone
                    teamName = teams[4];
                    GetAllPeople();
                    break;
            }
        }

        public void GetTeamMembers(string teamName) //this method prints individual teams 
        {
            if (TeamDictionary.ContainsValue(teamName))
            {
                Console.Clear();
                foreach (KeyValuePair<string, string> pair in TeamDictionary)
                {
                    if (pair.Value == teamName)
                    {
                        Console.WriteLine(pair.Key);
                    }
                }
                Console.WriteLine("\nPress any key to continue");
                Console.ReadKey();
                Console.Clear();
            }
        }

        public void GetAllPeople () //this method prints all the team members from all teams
        {
            Console.Clear();

            foreach (KeyValuePair<string, string> pair in TeamDictionary)
            {
                Console.WriteLine(pair.Key + " (" + pair.Value + ")");
            }
            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
            Console.Clear();
        }

    }
}
