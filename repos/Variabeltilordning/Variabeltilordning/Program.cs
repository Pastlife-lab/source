namespace datatyper;

internal class Datatyper
{
    int tall = 1;

    float desimalTall = 1.01F; // F for float og nøyaktig
    double desimalTall2 = 1.01;
    decimal desimalTall3 = 1.01M; // M for decimal og veldig nøyaktig

    char bokstav = 'a';  // char for en enkelt bokstav og bruker enkelt anførselstegn
    string tekst = "Hei";

    bool santUsant = true; // bool for sann/usann

    int[] tallArray = { 1, 2, 3 };
    string[] tekstArray = { "Hei", "på", "deg!" };

    List<int> listeMedTall = new List<int>(); //Lager en ny liste med tall

    public string ReturnString()
    {
        return tekst;
    }

    public int ReturnWholeNumber()
    { 
        return tall;
    }

    public double ReturnDouble() 
    {
        return 2.5;
    }

    public bool TrueFalse()
    {
        return santUsant;
    }

    public void Run()
    {
        Console.WriteLine($"Dette er en string: {ReturnString()}");
        Console.WriteLine($"Dette er en int: {ReturnWholeNumber()}");
        Console.WriteLine($"Dette er en double: {ReturnDouble()}");
        Console.WriteLine($"Dette er en boolean: {TrueFalse()}");
    }

}
