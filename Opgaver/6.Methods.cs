using System;

namespace Opgaver
{
    public class Methods
    {
        public static void Run()

        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Velkommen til opgaver omkring Methods, Params, Return og Recursion!");
            
        }

        public static void Method1()
        {
            
            Console.WriteLine("Lav et program som tjekker om en given værdi er lige eller ulige");

        }
        public static bool is_Lige(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("Number is lige");
                return true;
            }
            else
            {
                Console.WriteLine("Number is ulige");
                return false;
            }
        }
    }
}