using System;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var range = 250;
            var counts = new int[range];
            string text = "something";
            while (!string.IsNullOrWhiteSpace(text))
            {
                text = Console.ReadLine();

                foreach (var character in text ?? string.Empty)
                {
                    var normalized = char.ToLowerInvariant(character); // gjør om til lower case
                    counts[(int)normalized]++;
                }
                
                var total = counts.Sum(); //total telt

                var maxCountValue = counts.Max();
                var width = maxCountValue > 0 ? maxCountValue.ToString().Length : 1; // høyrejsutert 

                for (var i = 0; i < range; i++)
                {
                    if (counts[i] > 0)
                    {
                        var character = (char)i;
                        var count = counts[i]; 
                        var percent = total > 0 ? count * 100.0 / total : 0.0;

                        Console.WriteLine("{0} - {1," + width + "} ({2,6:0.0}%)", character, count, percent);
                    }
                }
            }
        }
    }
}
// 3. Endre det så det håndterer store og små bokstaver likt (bruk google/stackoverflow.com) (X)
// 4. Tell i prosent    (x)
// 5. Skriv ut tall høyrejustert, se eksempel:
//1
//1 (100,0%)

//20
//0-1 (33,3%)
//1-1 (33,3%)
//2-1 (33,3%)

//300
//0 - 3 (50,0)
//1 - 1 (16,7)
//2 - 1 (16,7)
//3 - 1 (16,7)
// blir resultatet av oppgaven =) 