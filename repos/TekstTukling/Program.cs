using System;

namespace TekstTukling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)   // evig loop for menyen
            {
                Console.WriteLine("=== TekstTukling ===");
                Console.WriteLine("1. snur tekst ");
                Console.WriteLine("2. bytter e -> a");
                Console.Write("Velg alternativ (1/2): ");

                string choose = Console.ReadLine();

                Console.Write("Skriv inn et ord: ");
                string input = Console.ReadLine();

                switch (choose)
                {
                    case "1":
                        string turn = RotateText(input);
                        Console.WriteLine($"Snudd tekst: {turn}");
                        break;

                    case "2":
                        string change = ChangeWord(input);
                        Console.WriteLine($"Endret tekst: {change}");
                        break;

                    default:
                        Console.WriteLine("Ugyldig valg!");
                        break;
                }

                Console.WriteLine();
            }
        }

                                         // 1 -> Snur teksten
        static string RotateText(string tekst)
        {
            char[] chars = tekst.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

                                          // 2 -> gjør alle (E) til (A)
        static string ChangeWord(string tekst)
        {
            return tekst.Replace('e', 'a').Replace('E', 'A');
        }
    }
}


//                 Lag et enkelt kommandobasert program med følgende meny: 
//                                                 1.RotateText
//                                                  2.Change word
//              Etter brukeren har valgt 1 eller to skal de promptes for å skrive inn et ord. Ordet skal ta enten snus eller endres med følgende funksjoner
//          1-> En funksjon som tar en tekst som parameter og som returnerer teksten snudd i motsatt rekkefølge. For eksempel skal 'Terje' bli til 'ejreT.
//          2-> En funksjon som bytter ut alle 'e' med 'a' i tekst du sender inn