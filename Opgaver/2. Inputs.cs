using System;

namespace Opgaver
{
    public class Inputs
    {
        public static void Run()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Velkommen til opgaver omkring Expressions, Operators og Inputs!");
            String1();
            Int1();
            Double1();
            Bool1();

            // Mini-projekter til inspiration:
            MiniProjekt1();
            MiniProjekt2();
        }

        public static void String1()
        {
            Console.WriteLine(
               "Lav et program som gemmer et input som en string og skriver strengen ud i konsollen"
            );

            Console.WriteLine("Indtast en streng: First try");
            // Lav opgaven herunder!
            string? inputString = Console.ReadLine();
            if (inputString != null)
            {
                Console.WriteLine("first try" + inputString);
            }
            else
            {
                Console.WriteLine("Input was null");
            }



        }

        public static void Int1()
        {
            Console.WriteLine(
                "Lav et program som gemmer et input som et tal og skriver tallet ud i konsollen"
            );

            Console.WriteLine("Indtast et tal:20");
            // Lav opgaven herunder!
            int inputInt;
            if (Int32.TryParse(Console.ReadLine(), out inputInt))
            {
                Console.WriteLine("20" + inputInt);

            }
            else
            {
                Console.WriteLine("Input was not a number");
            }
        }
        public static void Double1()
        {
            Console.WriteLine(
                "Lav et program som gemmer et input som et decimaltal og skriver tallet ud i konsollen"
            );

            Console.WriteLine("Indtast et decimaltal:10.25");
            // Lav opgaven herunder!
            double inputDouble;
            if (Double.TryParse(Console.ReadLine(), out inputDouble))
            {
                Console.WriteLine("10.25" + inputDouble);
            }
            else
            {
                Console.WriteLine("Input was not a number");

            }
        }

        public static void Bool1()
        {
            Console.WriteLine(
                "Lav et program som gemmer et input som en sandhedsværdi og skriver værdien ud i konsollen"
            );

            Console.WriteLine("Indtast en sandhedsværdi (sandt/falsk):true");
            // Lav opgaven herunder!
            bool inputBool;
                if (double.TryParse(Console.ReadLine(), out double result))
            {
                inputBool = result != 0;
                Console.WriteLine("true" + inputBool);
            }
            else
            {
                Console.WriteLine("Input was not a number");
            }
        }

        // Mini-projekt: Personlig profil (skabelon)
        public static void MiniProjekt1()
        {
            Console.WriteLine("\nMini-projekt: Personlig profil (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine("Lav et program, hvor brugeren indtaster sit navn, alder og hjemby.");
            Console.WriteLine(
                "Gem oplysningerne i variabler og udskriv en præsentationstekst, der bruger alle oplysningerne."
            );
            Console.WriteLine("Eksempel: Hej, jeg hedder X, er X år gammel og kommer fra X!");
            // Lav opgaven herunder!
            Console.WriteLine("Robert");
            string? name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Navn kan ikke være tomt.");
                return;
            }

            Console.WriteLine("18");
            int age;

            while (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("Ugyldig alder. Indtast venligst et gyldigt tal.");
            }
            Console.WriteLine("Roslev");
            string? hometown = Console.ReadLine();

            if (string.IsNullOrEmpty(hometown))
            {
                Console.WriteLine("Hjemby kan ikke være tom.");
                return;
            }

            Console.WriteLine(
                $"Hej, jeg hedder {name}, er {age} år gammel og kommer fra {hometown}!"
            );
        }

        // Mini-projekt 2: BMI-beregner (skabelon)
        public static void MiniProjekt2()
        {
            Console.WriteLine("\nMini-projekt 2: BMI-beregner (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine(
                "Lav et program, hvor brugeren indtaster sin vægt (i kg) og højde (i meter)."
            );
            Console.WriteLine("Programmet skal beregne brugerens BMI og udskrive resultatet.");
            Console.WriteLine(
                "Tip: BMI beregnes som vægt divideret med højde i anden (BMI = vægt / (højde * højde))."
            );

            //my work here

            Console.WriteLine("82");
            int weight;
            if (int.TryParse(Console.ReadLine(), out weight))
            {
                Console.WriteLine(weight);
            }
            Console.WriteLine("1.85");
            double height;
            if (double.TryParse(Console.ReadLine(), out height))
            {
                Console.WriteLine(height);
            }
            else
            {
                Console.WriteLine("Input was not a valid height.");
                return;
            }
          //to calculate bmi
          double bmi = weight / (height * height);
            Console.WriteLine($"Din BMI er: {bmi}");
            if (bmi < 18.5)
            {
                Console.WriteLine("Du er undervægtig.");
            }
            else if (bmi >= 18.5 && bmi < 24.9)
            {
                Console.WriteLine("Du har en normalvægt.");
            }
            else if (bmi >= 25 && bmi < 29.9)
            {
                Console.WriteLine("Du er overvægtig.");
            }
            else
            {
                Console.WriteLine("Du er svært overvægtig.");
            }
        }
    }
}
