using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feb_9_practice_2
{
    class Program
    {
        static void AddToList(List<string> students, string name)
        {
            students.Add(name);
        }

        static void ClearStudentsList(List<string> students)
        {
            students.Clear();
        }

        static void ListAllStudents(List<string> students)
        {
            foreach (string student in students)
            {
                Console.WriteLine(student);
            }
        }

        static void ShowStudentCount (List<string> students)
        {
            Console.WriteLine("There are " + students.Count + " students in this list.");
        }

        static void WriteToFile (List<string> students)
        {
            StreamWriter writer = new StreamWriter("students.txt");

            using (writer)
            {
                for (int i = 0; i < students.Count; i++)
                {
                    writer.WriteLine(students[i]);
                }
            }
        }

        static void Main(string[] args)
        {
            //Create a console app that uses a list to hold student names. 
            // After adding, write out options: Add another student, Clear out all students, 
            //List all students, show count of students, save to a file, or exit. Create methods for these operations.

            List<string> studentNames = new List<string>();
            bool result = false;
            int menuChoice = 0;
           
            while (true)
            {
                bool doubleBreak = false;
                result = false;

                while (result == false)
                {
                    Console.Title = "Welcome to Student Manager 9000!\n\n";
                    Console.WriteLine(Console.Title);

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("1 - Add a student");
                    Console.WriteLine("2 - List all students");
                    Console.WriteLine("3 - Clear all students");
                    Console.WriteLine("4 - Show the number of students");
                    Console.WriteLine("5 - Save student list to a file");
                    Console.WriteLine("6 - Exit");

                    string input = Console.ReadLine();


                    result = int.TryParse(input, out menuChoice);

                    if (result == true)
                    {
                        break;
                    }
                }

                switch (menuChoice)
                {
                    case 1:
                        Console.WriteLine("Enter a student's name to add them to the list.");
                        string studentInput = Console.ReadLine();
                        AddToList(studentNames, studentInput);
                        Console.WriteLine("Student Added.");
                        break;

                    case 2:
                        Console.WriteLine("List all students");
                        ListAllStudents(studentNames);
                        break;

                    case 3:
                        Console.WriteLine("Clear the Student List");
                        ClearStudentsList(studentNames);

                        if(studentNames.Count == 0)
                        {
                            Console.WriteLine("Success. List Cleared");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Show the number of students in the list");
                        ShowStudentCount(studentNames);
                        break;

                    case 5:
                        Console.WriteLine("Save student list to a file");
                        WriteToFile(studentNames);
                        Console.WriteLine("done");
                        break;

                    case 6:
                        Console.WriteLine("Exiting...");
                        doubleBreak = true;
                        break;

                    default:
                        Console.WriteLine("Restarting...");
                        continue;
                }
                
                if (doubleBreak == true)
                {
                    break;
                }

                System.Threading.Thread.Sleep(1500);
                Console.Clear();
            }




        }
    }
}
