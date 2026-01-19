using System;

namespace OrganTransolant
{
    class Person
    {
        public string Navn { get; set; }
        public int AntallNyrer { get; set; }
        public bool ErISlive { get; set; } = true;

        public Person(string navn, int antallNyrer)
        {
            Navn = navn;
            AntallNyrer = antallNyrer;
        }

        public void MisteNyre()
        {
            AntallNyrer--;
            Console.WriteLine($"{Navn} har gitt bort en nyre.");
        }

        public void MottaNyre()
        {
            AntallNyrer++;
            Console.WriteLine($"{Navn} har mottatt en ny nyre!");
        }

        public void VisStatus()
        {
            Console.WriteLine($"{Navn} har {AntallNyrer} nyre.");
        }
    }

    class Nyre
    {
        public Person Eier { get; set; }
        public bool ErSunn { get; set; }

        public Nyre(Person eier, bool erSunn)
        {
            Eier = eier;
            ErSunn = erSunn;
        }
    }

    class Sykehus
    {
        public void UtførTransplantasjon(Person donor, Person mottaker, Nyre nyre)
        {
            Console.WriteLine("Starter transplantasjon...");

            if (!nyre.ErSunn)
            {
                Console.WriteLine("Nyren er ikke sunn. Transplantasjon avbrutt.");
                return;
            }

            if (donor.AntallNyrer < 2)
            {
                Console.WriteLine($"{donor.Navn} kan ikke gi bort nyre.");
                return;
            }

            donor.MisteNyre();
            mottaker.MottaNyre();

            Console.WriteLine("Transplantasjonen var vellykket!");
        }
    }

    class Program
    {
        static void Main()
        {
            Person bernt = new Person("Bernt", 1);
            Person kaare = new Person("Kåre", 2);

            Nyre nyreFraKaare = new Nyre(kaare, true);

            Sykehus sykehus = new Sykehus();

            bernt.VisStatus();
            kaare.VisStatus();

            Console.WriteLine();
            sykehus.UtførTransplantasjon(kaare, bernt, nyreFraKaare);
            Console.WriteLine();

            bernt.VisStatus();
            kaare.VisStatus();
        }
    }
}

//                      Oppgave: Organ transplant!
//      Det har vært en akutt ulykke og Bernt ligger på sykehuset.
//      Han trenger en ny Nyre!
//      Heldigvis har fetteren hans Kåre to sunne Nyrer, og det er utført tester som tilsier at Kåre kan gi bort en av nyrene
//      til Bernt og det vil være en høy suksessrate for overlevelse!
//      Hjelp Bernt med å overleve!
//      Finn ut hva vi kan lage som objekter, og hva man kan lage som metoder i dette tilfellet.
//      Lag gjerne Console.WriteLine() - statements i koden slik at man ser hva som skjer!