namespace if_else_oppgave2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int number1 = 5;        // Bytt tall for og kontroller oppgaven =) 
            int number2 = 5;

            int result;
            if (number1 == number2)              
            {
                result = number1 * number2;     // skal skje med tall om dem er like skal dem multipliseres
                Console.WriteLine("Resultatet er : " + number1 + " * " + number2 + " = " + result);
            }
            else
            {
                result = number1 + number2;         //Skal skje med ulike tall og skal da legges sammen etter oppgavens 
                Console.WriteLine("Resultatet er: " + number1 + " + " + number2 + " = " + result);
            }
        }
    }
}
// Lag en metode som tar imot to tall og returnerer summen av tallene dersom de er ulike, 
// og returnerer tallene multiplisert med hverandre dersom de er like
