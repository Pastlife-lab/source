namespace Codealong3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Ford = new Bil("Ford","Mondeo", 2019, 40000);
            Console.WriteLine(Ford.Merke);
            List<Bil> biler = new List<Bil>();
            biler.Add(Ford);
        }
    }
}

/*                          Bil
 *                          - modell
 *                          - årstall
 *                          - pris
 *                          - generelt filter
 *                           Bruker vil kunne velge og filtrere
 *                              */

//  Lag noen biler som har forskjellige modeller, årstall og pris. Brukeren skal kunne velge om han er interessert i å filtrere på modell, 
//  årstall eller pris og vise frem feks enten kun subaru biler, biler som er produsert før 2019 eller biler som koster mindre enn 
//  budsjettet sitt