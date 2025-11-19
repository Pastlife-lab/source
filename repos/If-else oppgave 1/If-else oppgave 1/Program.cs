namespace If_else_oppgave_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int liteTall = 2;
            int størreTall = 6;

            
            if (liteTall < størreTall) // her er betingelsen at liteTall skal være mindre enn størreTall
            {
                Console.WriteLine($"Tallet {liteTall} er mindre enn eller lik {størreTall}.");
            }
            else if (liteTall == størreTall)        // byttet ut liteTall manuelt for og kontrollere at dette virker
            {
                Console.WriteLine($"Tallet {liteTall} er lik {størreTall}.");
            }
            else
            {
                Console.WriteLine($"Tallet {liteTall} er større enn {størreTall}."); // evt enklere og lagd input for brukeren for og se forskjellen 

            } 
        }
    }
}