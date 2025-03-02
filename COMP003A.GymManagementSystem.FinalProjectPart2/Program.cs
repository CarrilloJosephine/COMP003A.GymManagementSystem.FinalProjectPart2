
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
    /// Class saves meber info like full name and id number 
    class Member
    {
        public string FullName { get; set; }
        public string ID { get; set; }
        public Member(string name, string id)
        {
            FullName = name;
            ID = id;
        }
    }

    /// Class saves workout class info like the name, time, and trainer 
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
    /// Class incharge of what you can add,view,delete 
    class GymManagement
    {
        private List<Member> members = new List<Member>(); // Saves all the Members
        private List<WorkoutClass> workoutClass = new List<WorkoutClass>(); // Saves all workout classes

            /// add new member to the gym
            public void AddNewMember()
            {
                Console.WriteLine("Enter Full Name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter MemberShip ID");
                string id = Console.ReadLine();

                if (string.IsNullOrEmpty(name) & string.IsNullOrEmpty(id))
                {
                    Console.WriteLine("Invalid input name and id cant be empty");
                    return;
                }
                members.Add(new Member(name, id)); // adds the new member to the list of members
                Console.WriteLine("Member added successfully");
            }
            /// show all the workout classes
            public void ViewWorkoutClass() 
            {
                if (workoutClass.Count == 0)
                {
                    Console.WriteLine("No workout class");
                    return;
                }
                Console.WriteLine("Workout class: ");
                foreach (var WorkoutClass in workoutClass)
                {
                    Console.WriteLine("{WorkoutClass.ClassName} - {WorkoutClass.ClassTime} - {WorkoutClass.TrainerName}");
                }
            }
            /// to add more workout classes
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

                workoutClass.Add(new WorkoutClass(className, classTime, trainerName)); // gets all info and adds class
                Console.WriteLine("Workout class added successfully");
            }
            /// delete workout class
            public void DeleteWorkoutClass()
            {
            ViewWorkoutClass(); //Shows all the workout class if there is any
            if (WorkoutClass.Count == 0)
            {
                Console.WriteLine("No workout classes");
                return;
            }
            Console.WriteLine("Enter class name you want to delete: ");
            string workoutClass = Console.ReadLine();
            if (workoutClass == null)
            {
                Console.WriteLine("Class name not found");
                return;
            }
        }

    }
        
    }
    class program
    {
        static void Main()
        {
            while (true) 
            {
                Console.WriteLine("Gym Managemnt System");
                Console.WriteLine("1. Add a new member");
                Console.WriteLine("2. View workout class");
                Console.WriteLine("3. Add workout class");
                Console.WriteLine("4. Delete workout class");
                Console.WriteLine("5. Exit gym management");

            
        }
    }
}
