namespace Pokerdex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var pokemons = new List<Pokemon>();

            var PokeGener = new PokeGener();
            
            while (true)
            {
                PokeGener.Run();
            } 

            //// lager pokemons med "constructor"
            //Pokemon pikachu = new Pokemon("Pikachu", "Electric", 25, "Thunderbolt");  //Pokermon navn, type, level, abilities.        Alle pokermons abilities kan ha feil navn
            //Pokemon charmander = new Pokemon("Charmander", "Fire", 15, "Flamebreath"); //Pokermon navn, type, level, abilities.       Alle pokermons abilities kan ha feil navn
            //Pokemon bulbasaur = new Pokemon("Bulbasaur", "Grass/Poison", 10, "Water whipe"); //Pokermon navn, type, level, abilities. Alle pokermons abilities kan ha feil navn
            //Pokemon Newtwo = new Pokemon("Mewtwo", "Psychic", 70, "Mind Seer");  //Pokermon navn, type, level, abilities.             Alle pokermons abilities kan ha feil navn

            //pokemons.Add(pikachu);
            //pokemons.Add(charmander);
            //pokemons.Add(bulbasaur);
            //pokemons.Add(Newtwo);

            //foreach (var pokemon in pokemons)
            //{
            //    pokemon.DisplayInfo();
            //}

            // Info om pokemons
            //pikachu.DisplayInfo();      // henter info om pikachu
            //charmander.DisplayInfo();   // henter info om charmander
            //Newtwo.DisplayInfo();       // henter info om Newtwo
            //bulbasaur.DisplayInfo();    // henter info om bulbasaur
        }
    }
}