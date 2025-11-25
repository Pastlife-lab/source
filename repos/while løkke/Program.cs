namespace while_løkke
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                for (int i = 1; i <= 10; i++)   // sattt "i = 1;" for jeg vil skippe 0 og få 1 til 10 "riktig" ellers ville den ha startet på 0 og gått til 10 hvis jeg ikke har satt på <"="
                {
                    Console.WriteLine("Runde nummer: " + i);
                }
                break;   //satt på en brems så den ikke bare kjører avgårde i evig løkke landevei =)
            }
        }
    }
}
//                                          Oppgave 3:
//                  Lag en while-løkke som printer ut "Runde nummer:" + et tall som øker med 1 per runde, så lenge
//                  rundetelleren er mindre enn 10
