/*
// Author: Josephine Carrillo
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose Gym Manament system Final project part 2
*/
using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace COMP003A.GymManagementSystem.FinalProjectPart2
{
    /// <summary>
    /// Shows a gym member with there full name and id number 
    /// </summary>
    class Member
    {
        public string FullName { get; set; }
        public string MembershipID { get; set; }
        public Member(string name, string id)
        {
            FullName = name;
            MembershipID = id;
        }

        /// <summary>
        /// shows a workout class with the details like the name, time, and trainer 
        /// </summary>
        class WorkoutClass
        {
            public string ClassName { get; set; }
            public string ClassTime { get; set; }
            public string TrainerName { get; set; }
            public WorkoutClass(string className, string classTime, string trainerName)
            {
                ClassName = className;
                ClassTime = classTime;
                TrainerName = trainerName;
            }
        }
        class Program
        {
            static List<Member> members;
            static List<WorkoutClass> workoutClasses;

            public Program()
            {
                members = new List<Member>();
                workoutClasses = new List<WorkoutClass>();
            }
            /// <summary>
            /// add new member to the gym
            /// </summary>
            public void AddNewMember()
            {
                Console.WriteLine("Enter Full Name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter MemberShip ID");
                string id = Console.ReadLine();

                if (string.IsNullOrEmpty(name) & string.IsNullOrWhiteSpace(id))
                {
                    Console.WriteLine("Invalid input name and id cant be empty");
                    return;
                }
                members.Add(new Member(name, id));
                Console.WriteLine("Member added successfully");
            }
            /// <summary>'
            /// show all the workout classes
            /// </summary>
            public void ViewWorkoutClass() 
            {
                if (workoutClasses.Count == 0)
                {
                    Console.WriteLine("No workout class");
                    return;
                }
                Console.WriteLine("Workout class: ");
                for (int i = 0; i < workoutClasses.Count; i++)
                {
                    Console.WriteLine("");
                }
            }
            public void AddWorkoutClass ()
            {
                Console.WriteLine("Enter class name: ");
                string className = Console.ReadLine();
                Console.WriteLine("Enter class time: ");
                string classTime = Console.ReadLine();
                Console.WriteLine("Enter Trainer Name: ");
                string trainerName = Console.ReadLine();

                if (string.IsNullOrEmpty(trainerName) || string.IsNullOrWhiteSpace(classTime) || string.IsNullOrWhiteSpace(trainerName))
                {
                    Console.WriteLine("Invaild input vant be empty");
                    return;
                }

                workoutClasses.Add(new WorkoutClass(className, classTime, trainerName));
                Console.WriteLine("Workout class added successfully");
            }
            public void ViewWorkoutClasses()
            { 
                if (workoutClasses.Count == 0)
                {
                    Console.WriteLine("No workout classes");
                    return;
                }

            }
            public void DeleteWorkoutClass()
            {
                ViewWorkoutClass();
                if (workoutClasses.Count == 0) 
                    return;
                Console.WriteLine("Enter class number to remove: ");
                if (int.TryParse(Console.ReadLine(), out int id))
                { 
                    workoutClass.RemoveAt(id);
                    Console.WriteLine("class removed");
                }
            }

        }
        
    }
    class GymManagement
    {
        public void MainMenu()
        {
            while (true) 
            {
                Console.WriteLine("Gym Managemnt System");
                Console.WriteLine("1. Add a new member");
                Console.WriteLine("2. View workout class");
                Console.WriteLine("3. Add workout class");
                Console.WriteLine("4. Delete workout class");
                Console.WriteLine("5. Exit gym management");

            if (int.TryParse(Console.ReadLine(), out int Choice))
            {
                    switch (Choice)
                    {
                    Case 1: 
                        AddNewMember();
                    break;
                    Case 2: 
                        ViewWorkoutClass();
                    break;
                    Case 3:
                        AddWorkoutClass();  
                    break;
                    Case 4:
                        DeleteWorkoutClass();   
                    break;
                    Case 5:
                        ExitProgram();
                    break;
                    }
               
            }
        }
    }
}
