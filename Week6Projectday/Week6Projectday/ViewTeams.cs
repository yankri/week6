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
        static Dictionary<string, string> TeamDictionary = new Dictionary<string, string>()
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

        static List<string> teams = new List<string>() { "Hunters", "Helpers", "Angels", "Demons", "All Teams" };

        public static void PrintTeams ()
        {
            int choice = 0;

            while (true)
            {
                Console.WriteLine("Enter a number to select a team: ");
                int counter = 1;

                for (int i = 0; i < teams.Count; i++)
                {
                    Console.WriteLine(counter + " - " + teams[i]);
                    counter++;
                }
                string input = Console.ReadLine();
                bool result = int.TryParse(input, out choice);

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

            switch (choice)
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
                default:
                    teamName = teams[4];
                    GetAllPeople();
                    break;
            }
        }

        public static void GetTeamMembers(string teamName)
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
                Console.ReadKey();
                Console.Clear();
            }
        }

        public static void GetAllPeople ()
        {
            foreach (KeyValuePair<string, string> pair in TeamDictionary)
            {
                Console.WriteLine(pair.Key + " (" + pair.Value + ")");
            }
        }

    }
}
