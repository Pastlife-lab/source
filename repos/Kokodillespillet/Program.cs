namespace Kokodillespillet
{
    using System;

    class Program
    {
        static void Main()
        {
            Random rnd = new Random();
            int score = 0;

            while (true)
            {               
                int a = rnd.Next(1, 11); 
                int b = rnd.Next(1, 11);

                Console.WriteLine($"{a} _ {b}");

                Console.Write("Skriv <, > eller = : ");
                string svar = Console.ReadLine();

                if (svar != "<" && svar != ">" && svar != "=")
                {
                    Console.WriteLine("Spillet avsluttes!");
                    break;
                }

                string fasit;
                if (a < b)
                    fasit = "<";
                else if (a > b)
                    fasit = ">";
                else
                    fasit = "=";

                if (svar == fasit)
                {
                    score++;
                    Console.WriteLine("Riktig! +1 poeng.");
                }
                else
                {
                    score--;
                    Console.WriteLine($"Feil! Riktig svar var {fasit}. -1 poeng.");
                }

                Console.WriteLine($"Poeng: {score}\n");
            }
        }
    }
}
//                  Tallene må sjekkes om det første er større eller mindre eller lik det andre tallet,
//                  Det må verifiseres om brukeren har valgt riktig alternativ.
//                  Brukeren får et poeng per riktig svar, og mister et poeng per feil svar.
//                  Poengsummen printes til skjermen for hvert svar brukeren har gitt.
//                  Spillet avsluttes når brukeren skriver inn noe annet enn de tre alternativene.