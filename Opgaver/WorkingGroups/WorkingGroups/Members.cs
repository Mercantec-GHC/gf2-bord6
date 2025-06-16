using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkingGroups;

namespace WorkingGroups
{
    public class Member
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }

    }
    public static class AllMembers
    {
        public static readonly Dictionary<string, List<Member>> MembersByGroup = new()
        {
            ["GroupManagement"] = new List<Member>
        {
            new Member { Name = "James", Email = "james@email.com", Department = "Management" },
            new Member { Name = "Emily", Email = "emily@email.com", Department = "Management" },
            new Member { Name = "Michael", Email = "michael@email.com", Department = "Management" },
            new Member { Name = "Sophia", Email = "sophia@email.com", Department = "Management" },
            new Member { Name = "Daniel", Email = "daniel@email.com", Department = "Management" },
            new Member { Name = "Olivia", Email = "olivia@email.com", Department = "Management" },
            new Member { Name = "Matthew", Email = "matthew@email.com", Department = "Management" },
            new Member { Name = "Ava", Email = "ava@email.com", Department = "Management" },
            new Member { Name = "Christopher", Email = "christopher@email.com", Department = "Management" },
            new Member { Name = "Isabella", Email = "isabella@email.com", Department = "Management" }
        },
            ["GroupFinance"] = new List<Member>
    {
        new Member { Name = "William", Email = "william@email.com", Department = "Finance" },
        new Member { Name = "Emma", Email = "emma@email.com", Department = "Finance" },
        new Member { Name = "Alexander", Email = "alexander@email.com", Department = "Finance" },
        new Member { Name = "Mia", Email = "mia@email.com", Department = "Finance" },
        new Member { Name = "Ethan", Email = "ethan@email.com", Department = "Finance" },
        new Member { Name = "Charlotte", Email = "charlotte@email.com", Department = "Finance" },
        new Member { Name = "Jacob", Email = "jacob@email.com", Department = "Finance" },
        new Member { Name = "Amelia", Email = "amelia@email.com", Department = "Finance" },
        new Member { Name = "Logan", Email = "logan@email.com", Department = "Finance" },
        new Member { Name = "Harper", Email = "harper@email.com", Department = "Finance" }
    },
            ["GroupMarketing"] = new List<Member>
    {
        new Member { Name = "Benjamin", Email = "benjamin@email.com", Department = "Marketing" },
        new Member { Name = "Lily", Email = "lily@email.com", Department = "Marketing" },
        new Member { Name = "Noah", Email = "noah@email.com", Department = "Marketing" },
        new Member { Name = "Grace", Email = "grace@email.com", Department = "Marketing" },
        new Member { Name = "Elijah", Email = "elijah@email.com", Department = "Marketing" },
        new Member { Name = "Chloe", Email = "chloe@email.com", Department = "Marketing" },
        new Member { Name = "Lucas", Email = "lucas@email.com", Department = "Marketing" },
        new Member { Name = "Ella", Email = "ella@email.com", Department = "Marketing" },
        new Member { Name = "Henry", Email = "henry@email.com", Department = "Marketing" },
        new Member { Name = "Abigail", Email = "abigail@email.com", Department = "Marketing" }
    },
            ["GroupHR"] = new List<Member>
    {
        new Member { Name = "Jack", Email = "jack@email.com", Department = "Human Resources" },
        new Member { Name = "Zoe", Email = "zoe@email.com", Department = "Human Resources" },
        new Member { Name = "Samuel", Email = "samuel@email.com", Department = "Human Resources" },
        new Member { Name = "Nora", Email = "nora@email.com", Department = "Human Resources" },
        new Member { Name = "Owen", Email = "owen@email.com", Department = "Human Resources" },
        new Member { Name = "Madison", Email = "madison@email.com", Department = "Human Resources" },
        new Member { Name = "Caleb", Email = "caleb@email.com", Department = "Human Resources" },
        new Member { Name = "Hannah", Email = "hannah@email.com", Department = "Human Resources" },
        new Member { Name = "Ryan", Email = "ryan@email.com", Department = "Human Resources" },
        new Member { Name = "Layla", Email = "layla@email.com", Department = "Human Resources" }
    },
            ["GroupCustomerService"] = new List<Member>
    {
        new Member { Name = "David", Email = "david@email.com", Department = "Customer Service" },
        new Member { Name = "Victoria", Email = "victoria@email.com", Department = "Customer Service" },
        new Member { Name = "Luke", Email = "luke@email.com", Department = "Customer Service" },
        new Member { Name = "Eleanor", Email = "eleanor@email.com", Department = "Customer Service" },
        new Member { Name = "Nathan", Email = "nathan@email.com", Department = "Customer Service" },
        new Member { Name = "Scarlett", Email = "scarlett@email.com", Department = "Customer Service" },
        new Member { Name = "Isaac", Email = "isaac@email.com", Department = "Customer Service" },
        new Member { Name = "Aurora", Email = "aurora@email.com", Department = "Customer Service" },
        new Member { Name = "Aaron", Email = "aaron@email.com", Department = "Customer Service" },
        new Member { Name = "Bella", Email = "bella@email.com", Department = "Customer Service" }
         }
        };
        // helps to list all the gorups
        public static List<string> GetAllGroups() => GetMembersByGroup.Keys.ToList();
        // helps to list all the members
        public static List<Member> GetAllUsers() => groupMembers.Values.SelectMany(m => m).ToList();
        // this give a combiner list
        public static Dictionary<string, List<Member>> GetGroupsWithMembers => GroupMembers;

        public static List<Member> SearchUsers(string searchTerm)
        {
            GetAllUsers().Where(m =>
             m.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
             m.Email.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
             m.Department.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)).ToList();
        }




    }
}
