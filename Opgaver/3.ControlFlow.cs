using System;

namespace Opgaver
{
    public class ControlFlow
    {
        public static void Run()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine(@"Velkommen til opgaver omkring Control Flow med if, else if og else, 
            Switch og Ternary operator!");
            If1();
            If2();

            Switch1();
            Ternary1();

            MiniProjektQuiz();
            MiniProjektKarakterFeedback();
        }


        public static void If1()
        {
            Console.WriteLine("Lav et program som tjekker om en given værdi er højere eller lavere end 18");
            // Lav opgaven herunder!
            Console.WriteLine("Enter value:");
            int value = int.Parse(Console.ReadLine());
            if (value > 18)
            {
                Console.WriteLine("Value is higher than 18");
            }
            else if (value < 18)
            {
                Console.WriteLine("Value is less than 18");
            }
            else
            {
                Console.WriteLine("Value is 18");
            }
        }
        public static void If2()
        {
            Console.WriteLine("Lav et program som tjekker om en given værdi er lige eller ulige");
            // Lav opgaven herunder!
            Console.WriteLine("Enter value");
            int value = int.Parse(Console.ReadLine());
            if (value % 2 == 0)
            {
                Console.WriteLine("Value is lige");
            }
            else
            {
                Console.WriteLine("Value is ulige");
            }
        }

        public static void Switch1()
        {
            Console.WriteLine("Lav et program som tjekker om en given værdi er lige eller ulige");
            // Lav opgaven herunder!
            Console.WriteLine("Enter value");
            int value = int.Parse(Console.ReadLine());
            switch (value % 2)
            {
                case 0:
                    Console.WriteLine("Value is lige");
                    break;
                case 1:
                    Console.WriteLine("Value is ulige");
                    break;
                default:
                    Console.WriteLine("Something gone wrong");
                    break;
            }
        }
        public static void Ternary1()
        {
            Console.WriteLine("Lav et program som tjekker om en given værdi er lige eller ulige");
            // Lav opgaven herunder!
            Console.WriteLine("Enter value");
            int value = int.Parse(Console.ReadLine());
            string result = (value % 2 == 0) ? "Value is lige" : "Value is ulige";
            Console.WriteLine(result);

        }

        public static void MiniProjektQuiz()
        {
            Console.WriteLine("\nMini-projekt: Simpelt quiz-spil (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine("Lav et program, der stiller brugeren tre spørgsmål (du vælger selv spørgsmål og svar).");
            Console.WriteLine("Brugeren skal indtaste sit svar til hvert spørgsmål.");
            Console.WriteLine("Programmet skal tjekke, om svaret er rigtigt eller forkert, og til sidst udskrive, hvor mange rigtige brugeren fik.");
            Console.WriteLine("Tip: Brug variabler til at gemme point og svar, og if/else til at tjekke svarene.");
            // Lav opgaven herunder!
            Console.WriteLine("Question #1: What is the capital of Great Britain?");
            string answer_first = Console.ReadLine().Trim();
            int counter_answer = 0;

            if (answer_first != "London")
            {
                Console.WriteLine("Wrong!!");
            }
            else
            {
                Console.WriteLine("Right!!");
                counter_answer++;
            }

            Console.WriteLine("Question #2: Wat is the largest clock in the world?");
            string answer_second = Console.ReadLine().Trim();
            if (answer_second != "Big Ben")
            {
                Console.WriteLine("Wrong!!");
            }
            else
            {
                Console.WriteLine("Right!!");
                counter_answer++;
            }

            Console.WriteLine("Question #3: What is the biggest ocean?");
            string answer_third = Console.ReadLine().Trim();
            if (answer_third != "Pacific")
            {
                Console.WriteLine("Wrong!!");
            }
            else
            {
                Console.WriteLine("Right!!");
                counter_answer++;
            }
            Console.WriteLine($"Right answers: {counter_answer}");
        }

        public static void MiniProjektKarakterFeedback()
        {
            Console.WriteLine("\nMini-projekt: Karakter-feedback (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine("Lav et program, hvor brugeren indtaster en karakter (fx 12, 10, 7, 4, 02, 00 eller -3).");
            Console.WriteLine(@"Programmet skal give en passende feedback baseret på karakteren, 
            fx 'Super flot!', 'Godt klaret', 'Du kan gøre det bedre' osv.");
            Console.WriteLine("Brug if/else eller switch til at vælge feedbacken.");

            Console.WriteLine(@"Ekstra opgave: Lav så man indtaster flere karaktere 
            for en bruger og man regner gennemsnittet ud.");
            // Lav opgaven herunder!
            Console.WriteLine("Enter your mark. Enter 'exit' to finish.");
            string mark = Console.ReadLine();
            while (mark != "exit")
            {
                switch (mark)
                {
                    case "12":
                        Console.WriteLine("Exellent!");
                        break;

                    case "10":
                        Console.WriteLine("Very good!");
                        break;

                    case "07":
                    case "7":
                        Console.WriteLine("Not bad");
                        break;

                    case "04":
                    case "4":
                        Console.WriteLine("You can better");
                        break;

                    case "02":
                    case "2":
                        Console.WriteLine("Not good");
                        break;

                    case "00":
                    case "0":
                        Console.WriteLine("What is it?");
                        break;

                    case "-03":
                    case "-3":
                        Console.WriteLine("You lazy ass");
                        break;

                    default:
                        Console.WriteLine("Something gone wrong");
                        break;
                }
                Console.WriteLine("Enter your mark. Enter 'exit' to finish.");
                mark = Console.ReadLine();
            }
        }
    }
}