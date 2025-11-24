namespace Rnd_hobby_generator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hva heter du?");   //Spør brukeren om navn
            var Input = Console.ReadLine();  //Lagrer navnet i en variabel

            Console.WriteLine($"God dag " + Input + ", her kommer det noen forslag til sysselsetting"); //Hils brukeren med navnet deres



            string[] Hobby = ["Ta deg en joggetur/gåtur", "Gå på trening studio", "Ta noen runder Battlefield 6 med gutta", "Er det helg ta en kald en, eller kaffe hvis hverdag",
            "Ring en venn =)", "siden du kjeder deg... rydd/vask bopel"]; //lager et array med hobby forslag i string format siden det er tekst og ikke tall

            Random rnd = new(); //henter en radom hobby fra arrayet 

            Console.WriteLine($" {Input}: {Hobby[rnd.Next(Hobby.Length)]}"); //skriver ut en random hobby fra arrayet til brukeren som er forhånds definert

            //se om jeg får til en loop her senere hvis vedkommende ikke er fornøyd med forslaget.
        }
    }
}
