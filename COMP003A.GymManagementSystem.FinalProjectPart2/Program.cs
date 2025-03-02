/*
// Author: Josephine Carrillo
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose Gym Manament system Final project part 2
*/
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
        public Member ( string name, string id); 
        {
            FullName = name;
            MembershipID = id;
        }
    }
    /// <summary>
/// shows a workout class with the details like the name, time, and trainer 
/// </summary>
class WorkoutClass
{
public string ClassName { get; set; }
public string ClassTime { get; set; }
public string TrainerName { get; set; }
public WorkoutClass ( string className, string classTime, string trainerName )
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
     members = new List<Member> ();
     workoutClasses = new List<WorkoutClass> ();
 }

 }
