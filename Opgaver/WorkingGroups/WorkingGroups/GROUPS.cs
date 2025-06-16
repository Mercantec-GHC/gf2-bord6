using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace WorkingGroups
{
    public static class AllGroups
    {
        private static List<string> mygroups = new List<string>() { "GroupManagment", "GroupFinance", "GroupMarketing", "GroupHR", "GroupCustomerService" };
        private static List<string> GetAllGroups() => new List<string>(mygroups);

        public static bool ValidGroupName(string group)
        {
            return mygroups.Contains(group);
        }

        public static void Run()
        {
            Console.WriteLine("Welcome to the Group Management System");
            Console.WriteLine("Enter group name:");
            string? group = Console.ReadLine();
            if (string.IsNullOrEmpty(group) || !ValidGroupName(group))
            {
                Console.WriteLine("Invalid group name. Please try again.");
            }
            else
            {
                Console.WriteLine($"Members of {group} are:");
                var members = AllMembers.MembersByGroup(group);
                foreach (var member in members)

                {
                    Console.WriteLine(member);
                }
            }
        }
    }
}






