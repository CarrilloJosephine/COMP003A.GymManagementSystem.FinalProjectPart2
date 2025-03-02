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
