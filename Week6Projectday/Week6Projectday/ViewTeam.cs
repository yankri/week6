using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6Projectday
{
    //print out each team 
    //print out everyone Name (Team)

    class ViewTeam
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

            switch (choice)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                default:
                    break;
                    

            }

        }


    }
}
