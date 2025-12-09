namespace Pokerdex;

public class Pokemon   // Pokemon klasse
{
    public string Name { get; set; }    // get for å hente verdien, set for å sette verdien
    public string Type { get; set; }     // get for å hente verdien, set for å sette verdien
    public int Level { get; set; }      // get for å hente verdien, set for å sette verdien
    public string Abilities { get; set; } // get for å hente verdien, set for å sette verdien

    // Constructor
    public Pokemon(string name, string type, int level, string abilities)   // metode for å lage en pokemon ( navn, type, level )
    {
        Name = name;  // pokemon.name = name;
        Type = type;    // pokemon.type = type;
        Level = level;   // pokemon.level = level; 
        Abilities = abilities; // pokemon.abilities = abilities;
    }

    public void DisplayInfo()   // metode for å vise info om pokemon
    {
        Console.WriteLine($"Name: {Name}, Type: {Type}, Level: {Level}");  // skriver ut info om pokemon 
    }
    
}