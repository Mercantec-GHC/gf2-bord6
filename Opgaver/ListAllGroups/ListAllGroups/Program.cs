
using System;
using System.Net.Http.Headers;

namespace Project
{
    class Program
    {

        public void AllGroups()
        {
            Console.WriteLine("All groups");
        }
        List<string> allGroups = new List<string>() { "Group1", "Group2", "Group3", "Group4", "Group5", };

        public static List<string> Group1 (string group)
        {
            List<string> Managment = new List<string>()
    {
        "James", "Emily", "Michael", "Sophia", "Daniel",
        "Olivia", "Matthew", "Ava", "Christopher", "Isabella"
    };
            return Managment;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the group name:");
            string input = Console.ReadLine();
            if (input == "Group1")
            {
                var names = Group1(input);
            }
;


        }


    }



}






