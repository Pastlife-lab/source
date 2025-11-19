using System;

namespace IfElseNamespace
{
    public class IfElse
    {
        private int number = 5;
        private int number2 = 1;
        private bool isEqual = false;

        public void Run()
        {
            if (number == number2)
            {
                isEqual = true;
                Console.WriteLine("The numbers are equal.");
            }
            else
            {
                isEqual = false;
                Console.WriteLine("The numbers are not equal.");
            }
            if (isEqual)
            {
                number++;
            }
            else
            {
                number2--;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var ifElse = new IfElse();
            ifElse.Run();
        }
    }
}
