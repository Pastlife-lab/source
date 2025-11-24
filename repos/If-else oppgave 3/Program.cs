using System;

namespace If_else_oppgave_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 17;
            int number2 = 13;
 
            int sum = number1 + number2;

            if (sum == 30)
            {
                Console.WriteLine("Det var riktig");
            }
            else if (sum > 30 )
            {
                Console.WriteLine("Det ble for høyt");
            }
            else
            {
                Console.WriteLine("Det ble for lavt");
            }
        }   
    }
}
