using System.DirectoryServices.Protocols;

namespace AD_Konsol
{
    internal class Programs
    {
        static void Main(string[] args)
        {
            ADService aDService = new ADService();
            Console.WriteLine("Hello, World!");

            // Connect to the LDAP server
            var serverStatus = aDService.GetServer();
            Console.WriteLine(serverStatus);
            
            var groups = aDService.GetAllGroups();
            Console.WriteLine(groups[0].Name);

            Console.WriteLine("press any key to start menu");
            Console.ReadKey();
            bool IsRunning = true;
            while (IsRunning)
            {
                string? choice = Console.ReadLine();
                switch (choice?.ToLower())
                {
                    case "1":
                        ShowAllUsers();
                        break;

                    case "2":
                        SearchUsers();
                        break;
        
                    case "3":
                     SearchGroup();
                        break;

                    case "4":
                    ShowGroupsWithMembers();
                        break;

                    case "?":
                        Help();
                        break;

                    case "exit":
                        IsRunning = false;
                        break;

                    default:
                        Console.WriteLine("Doesnt Work");
                        break;
                }
            }

             void ShowAllUsers()
            {
                var users = aDService.GetAllUsers();
                foreach (var user in users)
                {
                    Console.WriteLine($"Name: {user.Name}");
                }
            }
             void SearchUsers()
            {
                Console.WriteLine("Search after name or press enter ");
                var name = Console.ReadLine();
                Console.WriteLine("Search after email or press enter ");
                var email = Console.ReadLine();
                Console.WriteLine("Search after department or press enter ");
                var department = Console.ReadLine();

                var result = aDService.SearchUsers( name , email, department);
                foreach (var user in result)
                {
                    Console.WriteLine($"Name: {user.Name}, Email: {user.Email}, Department: {user.Department}");
                }
            }
             void SearchGroup()
            {
                Console.WriteLine("Search after group name or press enter ");
                var groupName = Console.ReadLine();

                var result = aDService.SearchGroups(groupName);
                foreach (var group in result)
                {
                    Console.WriteLine($"Group Name: {group.Name}, Description: {group.Description}");
                }
            }
            
            void ShowGroupsWithMembers()
            {
                var groups = aDService.GetGroupsWithMembers();
                foreach (var group in groups)
                {
                    Console.WriteLine($"Group Name: {group.Name}");
                    foreach (var member in group.Members)
                    {
                        Console.WriteLine($"  Member: {member.Name}");
                    }
                }
            }
            
        }

        public static void Help()
        {
            Console.WriteLine("Welcome to the Group Management System");
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. View all groups");
            Console.WriteLine("2. View group members");
            Console.WriteLine("? for help");
            Console.WriteLine("exit to quit");
        }
    }
}
            
