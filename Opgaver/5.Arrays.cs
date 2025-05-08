using System;
using System.Collections.Generic;
using System.Linq;

namespace Opgaver
{
    public class Arrays
    {
        public static void Run()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Velkommen til opgaver omkring Arrays, List og Dictionary!");

            // Opgaverne herunder går igennem ting vi skal kunne med arrays, list og dictionary
            // Da I ikke har lært omkring loops og metoder endnu, er det ikke nødvendigt at bruge dem her
            // I må dog gerne bruge loops og metoder i opgaverne herunder

            Array1();
            Array2();
            Array3();
            List1();
            List2();
            List3();
            List4();
            List5();
            Dict1();
            Dict2();
            MiniProjektKlasseliste();
            MiniProjektIndkøbsliste();
        }

        public static void Array1()
        {
            Console.WriteLine("Opgave 1 (Array):");
            Console.WriteLine("Lav et program som gemmer 5 fornavne som brugeren indtaster i et array.");
            // Lav opgaven herunder!
            string[] navne = new string[5];

            for (int i = 0; i < navne.Length; i++)
            {
                Console.WriteLine("Enter name:");
                navne[i] = Console.ReadLine();
            }

            Console.WriteLine("Here is list:");
            for (int i = 0; i < navne.Length; i++)
            {
                Console.WriteLine(navne[i]);
            }
        }
        public static void Array2()
        {
            Console.WriteLine("Opgave 2 (Array):");
            Console.WriteLine("Lav et program som gemmer 5 tal i et array og udskriver det største tal.");
            // Lav opgaven herunder!
            int[] values = new int[5];

            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine("Enter value:");
                values[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The biggest is: {values.Max()}");
        }

        public static void Array3()
        {
            Console.WriteLine("Opgave 3 (Array):");
            Console.WriteLine("Lav et program som gemmer 5 bynavne i et array og udskriver dem alle i omvendt rækkefølge.");
            // Lav opgaven herunder!
            string[] city_list = new string[5];
            for (int i = 0; i < city_list.Length; i++)
            {
                Console.WriteLine("Enter name:");
                city_list[i] = Console.ReadLine();
            }

            Console.WriteLine("Here is list:");
            for (int i = city_list.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(city_list[i]);
            }

        }

        public static void List1()
        {
            Console.WriteLine("Opgave 1 (List):");
            Console.WriteLine("Lav et program som gemmer 5 fornavne som brugeren indtaster i en liste.");
            // Lav opgaven herunder!
            List<string> names = new List<string>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter name:");
                names.Add(Console.ReadLine());

            }

            Console.WriteLine("Here is the list:");
            Console.WriteLine(string.Join(", ", names));
        }

        public static void List2()
        {
            Console.WriteLine("Opgave 2 (List):");
            Console.WriteLine("Lav et program hvor brugeren kan blive ved med at indtaste navne indtil de skriver 'stop'. Udskriv alle navnene til sidst.");
            // Lav opgaven herunder!
            List<string> names = new List<string>();
            Console.WriteLine("Enter list, finish with 'stop'");

            string input;
            while ((input = Console.ReadLine()) != "stop")
            {
                names.Add(input);
            }
            Console.WriteLine("Here is the list:");
            Console.WriteLine(string.Join(", ", names));
        }

        public static void List3()
        {
            Console.WriteLine("Opgave 3 (List):");
            Console.WriteLine("Lav et program hvor brugeren indtaster 5 tal i en liste og programmet udskriver gennemsnittet.");
            // Lav opgaven herunder!
            List<int> values = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                values.Add(int.Parse(Console.ReadLine()));
            }

            //double average = values.Average();

            double sum = 0;
            foreach (int value in values)
            {
                sum += value;
            }
            sum = sum / values.Count;
            Console.WriteLine($"Gennemsnit: {sum}");
        }

        public static void List4()
        {
            Console.WriteLine("Opgave 4 (List):");
            Console.WriteLine("Lav et program hvor brugeren indtaster navne på ting de skal købe, og kan fjerne ting fra listen igen. Udskriv listen til sidst.");
            // Lav opgaven herunder!
            List<string> list = new List<string>();
            Console.WriteLine("Enter list, finish with stop:");
            string input;
            while ((input = Console.ReadLine()) != "stop")
            {
                list.Add(input);
            }
            Console.WriteLine("Here is the list:");
            Console.WriteLine(string.Join(", ", list));

            Console.WriteLine("Enter value to delete");
            string choice = Console.ReadLine();
            list.Remove(choice);

            Console.WriteLine("New list:");
            Console.WriteLine(string.Join(", ", list));

        }

        public static void List5()
        {
            Console.WriteLine("Opgave 5 (List):");
            Console.WriteLine("Lav et program hvor brugeren indtaster navne på sine venner i en liste og programmet udskriver hvor mange navne der starter med 'A'.");
            // Lav opgaven herunder!
            List<string> names = new List<string>();
            string input;
            Console.WriteLine("Enter list, finish with stop:");
            while ((input = Console.ReadLine()) != "stop")
            {
                names.Add(input);
            }
            Console.WriteLine("Here is the list:");
            Console.WriteLine(string.Join(", ", names));

            int counter = 0;
            foreach (string name in names)
            {
                if (name[0] == 'A')
                    counter++;

            }
            Console.WriteLine("Names with first 'A': ");
            Console.WriteLine(counter);
        }


        public static void Dict1()
        {
            Console.WriteLine("Opgave 1 (Dictionary):");
            Console.WriteLine("Lav et program hvor du gemmer navne og alder på 3 personer i en dictionary og udskriver dem alle.");
            // Lav opgaven herunder!
            // Husk syntaxen for Dictionary<type, type> navn = new Dictionary<type, type>();
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            string key;
            int value;
            Console.WriteLine("Enter key-value 3 times:");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter key:");
                key = Console.ReadLine();

                Console.WriteLine("Enter value:");
                value = int.Parse(Console.ReadLine());

                dictionary[key] = value;
            }

            Console.WriteLine("Dictionary is:");
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }

        public static void Dict2()
        {
            Console.WriteLine("Opgave 2 (Dictionary):");
            Console.WriteLine("Lav et program hvor brugeren kan indtaste et navn og få alderen på personen ud fra dictionaryen fra før.");
            // Lav opgaven herunder!
            Dictionary<string, int> dictionary = new Dictionary<string, int>()
            {
                { "Andrii", 37 },
                { "Kateryna", 32 },
                { "Alice", 5 },
                { "Astrid", 1 }
            };

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            Console.WriteLine("Enter name and get age:");
            string name = Console.ReadLine();

            foreach (var item in dictionary)
            {
                if (item.Key == name)
                    Console.WriteLine($"Age is: {item.Value}");
            }

        }
        public static void MiniProjektKlasseliste()
        {
            Console.WriteLine("\nMini-projekt: Klasseliste (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine("Lav et program, hvor brugeren indtaster navnene på alle elever i en klasse (fx 5 navne).");
            Console.WriteLine("Gem navnene i en liste og udskriv hele klasselisten i konsollen.");
            // Lav opgaven herunder!
            List<string> names = new List<string>();

            Console.WriteLine("Enter list, finish with 'stop'");

            string input;
            while ((input = Console.ReadLine()) != "stop")
            {
                names.Add(input);
            }
            Console.WriteLine("Here is the list:");
            Console.WriteLine(string.Join(", ", names));
        }

        public static void MiniProjektIndkøbsliste()
        {
            Console.WriteLine("\nMini-projekt: Indkøbsliste (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine("Lav et program, hvor brugeren indtaster navnet på tre ting, de skal købe i supermarkedet.");
            Console.WriteLine("Gem tingene i en liste og udskriv en indkøbsliste til brugeren.");
            // Lav opgaven herunder!

            List<string> list = new List<string>();

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Enter goods number {i}:");
                list.Add(Console.ReadLine());
            }

            Console.WriteLine("Here is the list of goods:");
            Console.WriteLine(string.Join(", ", list));
        }
    }
}