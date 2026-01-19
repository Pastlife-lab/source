using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Codealong3
{
    internal class Bil
    {
        public string Merke { get; set; }
        string Modell { get; set; }
        int År { get; set; }
        int Pris { get; set; }
        
        
          public Bil(string merke, string modell, int år, int pris)
          {
              Merke = merke;
              Modell = modell;
              År = år;
              Pris = pris;
          }
          
        



    }       

}











/*                          Biler
 *                          -modell
 *                          -årstall
 *                          -pris
 *                          - generelt filter
 *                              Bruker vil kunne velge og filtrere
 *                          
 */
//Lag noen biler som har forskjellige modeller, årstall og pris. Brukeren skal kunne velge om han er interessert i å filtrere på modell, 
//  årstall eller pris og vise frem feks enten kun subaru biler, biler som er produsert før 2019 eller biler som koster mindre enn 
//  budsjettet sitt 