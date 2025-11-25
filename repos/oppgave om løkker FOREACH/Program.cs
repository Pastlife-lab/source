namespace oppgave_om_løkker_FOREACH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tekst = "Hei på deg!";
            foreach (char letter in tekst)
            {
                Console.WriteLine(letter);
            }
        }
    }
}
//                                              Oppgave 2:
//                      Lag en foreach-løkke som går igjennom hver bokstav i en string og printer den til konsollen.
//                      Hint: en string kan brukes på samme måte som et array!