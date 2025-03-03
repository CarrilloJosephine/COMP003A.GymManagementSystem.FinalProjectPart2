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
    /// Class saves meber info like full name and id number 
    class Member
    {
        public string FullName { get; set; }  // full Name of new gym member
        public string ID { get; set; }       // unique id for each new member 
        public List<WorkoutClass> WorkoutClasses { get; set; } // list of workout classes the members are in 

        /// Constructor  
        public Member(string name, string id)
        {
            FullName = name;
            ID = id;
            WorkoutClasses = new List<WorkoutClass>();     // start workoutclass list
        }
    }

    /// Class saves workout class info like the name, time, and trainer 
    class WorkoutClass
    {
         public string ClassName { get; set; }    // Name of workout class
         public string ClassTime { get; set; }    // The time of the workout class
         public string TrainerName { get; set; }  // The name of the trainer for the class
        /// constructor to ask for info of workoutclass
         public WorkoutClass(string className, string classTime, string trainerName)
         {
            ClassName = className;
            ClassTime = classTime;
            TrainerName = trainerName;
         }
    }
    /// Class incharge of gym member and workout classes 
    class GymManagement
    {
        private List<Member> members = new List<Member>(); // Saves all the Members

            /// add new member to the gym
            public void AddNewMember()
            {
                try
                {
                    Console.WriteLine("Enter Full Name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter MemberShip ID");
                    string id = Console.ReadLine();
                    
                    /// input validation
                    if (string.IsNullOrEmpty(name) & string.IsNullOrEmpty(id))
                    {
                        Console.WriteLine("Invalid input name and id cant be empty");
                        return;
                    }
                    
                /// check if id already exsist 
                bool memberExists = false;
                foreach (Member member in members)
                {
                    if (member.ID == id)
                    {
                        memberExists = true;
                        break;
                    }
                }
                if (memberExists) 
                {
                    Console.WriteLine("A member already has this ID pick a different ID number");
                    return;
                }
                    /// add new member to list 
                    members.Add(new Member(name, id));
                Console.WriteLine("New member added");
                }
                catch 
                { 
                    Console.WriteLine("Invaild input");
                }
            }
        /// Method show all the workout classes
        public void ViewWorkoutClass()
        {
            Console.Write("Enter Member ID: ");
            string id = Console.ReadLine();

            /// Find the member with the ID
            Member findMember = null;
            foreach (Member member in members)
            {
                if (member.ID == id)
                {
                    findMember = member;
                    break;
                }

            }

            /// show workout classes 
            if (findMember.WorkoutClasses.Count == 0)
            {
                Console.WriteLine($"{findMember.FullName} has no workout class yet add some");
            }
            else
            {
                Console.WriteLine($"These are {findMember.FullName} workout classes:");
                foreach (var workout in findMember.WorkoutClasses)
                {
                    Console.WriteLine($"Class name is {workout.ClassName} is at {workout.ClassTime}, and your trainer is {workout.TrainerName}");
                }
            }
        }
        /// to add more workout classes to member
        public void AddWorkoutClass()
        {
            Console.WriteLine("Enter your Id number: ");
            string id = Console.ReadLine();


            /// Find the memebr with there ID 
            Member findmember = null;
            foreach (Member member in members)
            {
                if (member.ID == id)
                {
                    findmember = member;
                    break;
                }

            }

            if (findmember == null)
            {
                Console.WriteLine("member is not found check if id entered correctly or sign up");
                return;
            }

            /// Enter the info for the classes
            Console.WriteLine("Enter the name of the class: ");
            string className = Console.ReadLine();
            Console.WriteLine("Enter the time you want the class: ");
            string classTime = Console.ReadLine();
            Console.WriteLine("Enter the name of the trainer you want");
            string classTrainer = Console.ReadLine();

        }
    }
        
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
                string choice = Console.ReadLine();  // Reads teh numebr you input

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
