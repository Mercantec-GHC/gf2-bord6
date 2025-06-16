using System;
using System.Diagnostics.Metrics;

namespace Opgaver
{
    public class Loops
    {
        public static void Run()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Velkommen til opgaver omkring Loops både med og uden datastrukturer!");
            Loop1();
            Loop2();
            Loop3();
            Loop4();
            Loop5();
            Loop6();
            Loop7();
            Loop8();
            Loop9();
            Loop10();
            BankeBøf();
            MiniProjektLommeregner();

        }

        public static void Loop1()
        {
            Console.WriteLine("Opgave 1:");
            Console.WriteLine("Brug et loop til at udskrive tallene fra 1 til 10.");
            // Lav opgaven herunder!
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void Loop2()
        {
            Console.WriteLine("Opgave 2:");
            Console.WriteLine("Brug et loop og en if-betingelse til at udskrive alle lige tal fra 2 til 20.");
            // Lav opgaven herunder!
            for (int i = 2; i <= 20; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }
        }

        public static void Loop3()
        {
            Console.WriteLine("Opgave 3:");
            Console.WriteLine("Brug et loop til at lægge alle tal fra 1 til 100 sammen og udskriv resultatet.");
            // Lav opgaven herunder!
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }

        public static void Loop4()
        {
            Console.WriteLine("Opgave 4:");
            Console.WriteLine("Bed brugeren om at indtaste sit navn og et tal. Udskriv navnet det antal gange ved hjælp af et loop.");
            // Lav opgaven herunder!
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter how many times:");
            int repeat = int.Parse(Console.ReadLine());
            for (int i = 0; i < repeat; i++)
            {
                Console.WriteLine(name);
            }
        }

        public static void Loop5()
        {
            Console.WriteLine("Opgave 5:");
            Console.WriteLine("Bed brugeren om at indtaste et tal. Brug et loop til at udskrive alle tal fra det indtastede tal og ned til 1.");
            // Lav opgaven herunder!
            Console.WriteLine("Enter number:");
            int number = int.Parse(Console.ReadLine());
            for (int i = number; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }

        public static void Loop6()
        {
            Console.WriteLine("Opgave 6:");
            Console.WriteLine(@"Brug et loop til at udskrive alle bogstaverne i dit navn (ét bogstav pr. linje). 
            Navnet skal være gemt i en string variabel.");
            // Lav opgaven herunder!
            string name = "Andrii";
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }
        }

        public static void Loop7()
        {
            Console.WriteLine("Opgave 7:");
            Console.WriteLine("Brug et loop til at tælle, hvor mange gange bogstavet 'a' optræder i en tekst, som brugeren indtaster.");
            // Lav opgaven herunder!
            Console.WriteLine("Enter text:");
            string text = Console.ReadLine();
            int counter = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a')
                    counter++;
            }
            Console.WriteLine($"There are {counter} 'a' in the text");
        }

        public static void Loop8()
        {
            Console.WriteLine("Opgave 8:");
            Console.WriteLine("Brug et loop til at udskrive alle ulige tal mellem 1 og 50.");
            // Lav opgaven herunder!
            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 != 0)
                    Console.WriteLine(i);
            }
        }

        public static void Loop9()
        {
            Console.WriteLine("Opgave 9:");
            Console.WriteLine("Bed brugeren om at indtaste 5 tal (ét ad gangen). Brug et loop til at lægge dem sammen og udskriv summen til sidst.");
            // Lav opgaven herunder!
            Console.WriteLine("Write 5 values, separate with enter:");
            int sum = 0;
            for (int i = 1; i <= 5; i++)
            {
                sum += int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Result is: {sum}");
        }

        public static void Loop10()
        {
            Console.WriteLine("Opgave 10:");
            Console.WriteLine("Lav et program, hvor brugeren skal gætte et hemmeligt tal mellem 1 og 10. Brug et loop, så brugeren kan gætte indtil det rigtige tal er fundet.");
            // Lav opgaven herunder!
            Random rnd = new Random();
            int secretNumber = rnd.Next(1, 10); // от 1 до 10 включительно
            int value;
            Console.WriteLine("Enter value:");
            while ((value = int.Parse(Console.ReadLine())) != secretNumber)
            {
                Console.WriteLine("Wrong!! Try again");
            }
            Console.WriteLine("Right! Good job");
        }

        public static void BankeBøf()
        {
            Console.WriteLine(@"Lav et program med et loop, som udskriver tallene fra 1 til 30. 
            Udskriv 'Banke' hvis tallet er deleligt med 3, 'Bøf' hvis tallet er deleligt med 5 
            og 'BankeBøf' hvis tallet er deleligt med både 3 og 5.");
            // Lav opgaven herunder!
            for (int i = 1; i <= 30; i++)
            {
                Console.Write($"{i} ");
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("Bankebøf");
                else if (i % 3 == 0)
                    Console.WriteLine("Banke");
                else if (i % 5 == 0)
                    Console.WriteLine("Bøf");
                else Console.WriteLine();
            }

        }
        public static void MiniProjektLommeregner()
        {
            Console.WriteLine("\nMini-projekt: Simpel lommeregner (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine("Lav et program, hvor brugeren indtaster to tal og vælger en regneart (+, -, * eller /).");
            Console.WriteLine("Programmet skal udregne og udskrive resultatet.");
            Console.WriteLine("Tip: Brug if/else eller switch til at vælge regnearten.");
            // Lav opgaven herunder!
            float result;

            while (true)
            {
                Console.Write("Enter first number: ");
                int first_value = int.Parse(Console.ReadLine());

                Console.Write("Enter second number: ");
                int second_value = int.Parse(Console.ReadLine());

                Console.Write("Enter operation (+, -, *, / or 'exit'): ");
                string operation = Console.ReadLine();

                if (operation == "exit")
                    break;

                switch (operation)
                {
                    case "+":
                        result = first_value + second_value;
                        Console.WriteLine($"Result: {result}");
                        break;

                    case "-":
                        result = first_value - second_value;
                        Console.WriteLine($"Result: {result}");
                        break;

                    case "*":
                        result = first_value * second_value;
                        Console.WriteLine($"Result: {result}");
                        break;

                    case "/":
                        result = (float)first_value / second_value;
                        Console.WriteLine($"Result: {result}");
                        break;
                        
                    default:
                        Console.WriteLine("Something is wrong");
                        break;
                }
            }
        }
    }
}