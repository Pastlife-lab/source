using System;

namespace Student_reg
{
    class Program
    {
        static void Main()
        {
            // Opprett studenter
            Student student1 = new Student
            {
                Navn = "Jon Fredrik",
                Alder = 41,
                Studieprogram = "Informatikk",
                StudentID = 11
            };

            Student student2 = new Student
            {
                Navn = "Lissom Person",
                Alder = 22,
                Studieprogram = "Dataingeniør",
                StudentID = 21
            };

            // Opprett fag
            Fag fag1 = new Fag
            {
                Fagkode = "IT101",
                Fagnavn = "Programmering",
                AntallStudiepoeng = 10
            };

            Fag fag2 = new Fag
            {
                Fagkode = "IT102",
                Fagnavn = "Databaser",
                AntallStudiepoeng = 10
            };

            // Opprett karakterer
            Karakter karakter1 = new Karakter
            {
                Student = student1,
                Fag = fag1,
                Karakterverdi = "F"
            };

            Karakter karakter2 = new Karakter
            {
                Student = student2,
                Fag = fag2,
                Karakterverdi = "B"
            };

            // Skriv ut informasjon
            student1.SkrivUtInfo();
            student2.SkrivUtInfo();

            fag1.SkrivUtInfo();
            fag2.SkrivUtInfo();

            karakter1.SkrivUtInfo();
            karakter2.SkrivUtInfo();
        }
    }
}