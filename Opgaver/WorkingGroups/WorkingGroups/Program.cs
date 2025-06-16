using System.DirectoryServices.Protocols;
using System.Security.Cryptography.X509Certificates;

namespace WorkingGroups
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello User");
            Help();
            bool isRunning = true;
            while (isRunning)
            {
                string? choice = Console.ReadLine();
                switch (choice?.ToLower())
                {
                    case "1":
                        AllGroups.Run();
                        break;

                    case "2":
                        Member.Run();
                        break;

                    case "?":
                        Help();
                        break;

                    case "exit":
                        isRunning = false;
                        break;

                    default:
                        Console.WriteLine("Doesnt Work");
                        break;
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
