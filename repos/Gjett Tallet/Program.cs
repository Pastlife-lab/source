using System;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        bool playAgain = true;

        while (playAgain)
        {
            int fasit = rnd.Next(1, 101);
            bool correct = false;

            Console.WriteLine("Jeg har valgt et tall mellom 1 og 100. Gjett!");

            while (!correct)
            {
                Console.Write("Skriv inn et tall: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out int tall))
                {
                    Console.WriteLine("Du må skrive inn et gyldig tall!");
                    continue;
                }

                if (tall < fasit)
                {
                    Console.WriteLine("Høyere!");
                }
                else if (tall > fasit)
                {
                    Console.WriteLine("Lavere!");
                }
                else
                {
                    Console.WriteLine("Riktig! ");
                    correct = true;
                }
            }

            Console.Write("Vil du spille igjen? (j/n): ");
            string svar = Console.ReadLine().ToLower();

            if (svar != "j")
            {
                playAgain = false;
            }
        }

        Console.WriteLine("Takk for spillet!");
    }
}