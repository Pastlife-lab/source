namespace Switch_oppgave_1
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Skriv et tall mellom 1-7 for å få vite hvilken dag det er:");
            var input = Console.ReadLine();
                       
            switch (input)
            {
                case "1":
                    Console.WriteLine("Det er Mandag");
                    break;
                case "2":
                    Console.WriteLine("Det er Tirsdag");
                    break;
                case "3":
                    Console.WriteLine("Det er Onsdag");
                    break;
                case "4":
                    Console.WriteLine("Det er Torsdag");
                    break;
                case "5": 
                    Console.WriteLine("Det er Fredag");
                    break;
                case "6":
                    Console.WriteLine("Det er Lørdag");
                    break;
                case "7":
                    Console.WriteLine("Det er Søndag");
                    break;              
                default:
                    Console.WriteLine("Ugyldig tall, vennligst skriv et tall mellom 1-7");
                    Main();
                    break;
            }
        }
    }
}
