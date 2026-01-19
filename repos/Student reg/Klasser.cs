using System;

namespace Student_reg
{
    class Student
    {
        public string Navn { get; set; }
        public int Alder { get; set; }
        public string Studieprogram { get; set; }
        public int StudentID { get; set; }

        public void SkrivUtInfo()
        {
            Console.WriteLine("Student:");
            Console.WriteLine($"Navn: {Navn}");
            Console.WriteLine($"Alder: {Alder}");
            Console.WriteLine($"Studieprogram: {Studieprogram}");
            Console.WriteLine($"StudentID: {StudentID}");
            Console.WriteLine();
        }
    }

    class Fag
    {
        public string Fagkode { get; set; }
        public string Fagnavn { get; set; }
        public int AntallStudiepoeng { get; set; }

        public void SkrivUtInfo()
        {
            Console.WriteLine("Fag:");
            Console.WriteLine($"Fagkode: {Fagkode}");
            Console.WriteLine($"Fagnavn: {Fagnavn}");
            Console.WriteLine($"Studiepoeng: {AntallStudiepoeng}");
            Console.WriteLine();
        }
    }

    class Karakter
    {
        public Student Student { get; set; }
        public Fag Fag { get; set; }
        public string Karakterverdi { get; set; }

        public void SkrivUtInfo()
        {
            Console.WriteLine("Karakter:");
            Console.WriteLine($"Student: {Student.Navn}");
            Console.WriteLine($"Fag: {Fag.Fagnavn}");
            Console.WriteLine($"Karakter: {Karakterverdi}");
            Console.WriteLine();
        }
    }
}