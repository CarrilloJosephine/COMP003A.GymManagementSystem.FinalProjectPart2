/*
// Author: Josephine Carrillo
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose Gym Manament system Final project part 2
*/

using System.Collections;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace COMP003A.GymManagementSystem.FinalProjectPart2
{     
    /// The main class program that has the menu options 
    class program
    {
        static void Main()
        {
            GymManagement gymManagement = new GymManagement(); // Runs GymManagement 
      
            while (true)  // keeps menu running until you want to exit 
            {
                Console.WriteLine("Gym Managemnt System");
                Console.WriteLine("1. Add a new member");
                Console.WriteLine("2. View workout class");
                Console.WriteLine("3. Add workout class");
                Console.WriteLine("4. Delete workout class");
                Console.WriteLine("5. Exit gym management");
                Console.WriteLine("Pick a number 1-5");
                string choice = Console.ReadLine();  // Reads the numebr you input

                switch (choice)  // Handles what number you input
                {
                    case "1":
                        gymManagement.AddNewMember(); // calls AddMember 
                        break;
                    case "2":
                        gymManagement.ViewWorkoutClass(); // calls ViewWorkoutClass
                        break;
                    case "3":
                        gymManagement.AddWorkoutClass(); // calls AddWorkoutClass
                        break;
                    case "4":
                        gymManagement.DeleteWorkoutClass(); // calls DeleteWorkoutClass
                        break;
                    case "5":
                        Console.WriteLine("Exiting Gym management");
                        return; //exit program
                        default:
                        Console.WriteLine("Invaild input pick i number 1-5");
                        break;
                }

            }
        }
    }

}
