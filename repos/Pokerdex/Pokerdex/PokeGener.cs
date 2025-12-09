using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Channels;

namespace Pokerdex
{
    internal class PokeGener
    {
        private List<Pokemon> _pokemons;            // list men med privat (underscore før navn)

        public PokeGener()                          //Skal generere pokemons
        {
            _pokemons = [];
        }

        public void Run()  
        {
            Console.WriteLine("Velkommen til PokeDex meny ");     // gjør  at du kan lage en liste i Terminalen
            Console.WriteLine("""                         
                              ctrl + C to exit
                              1.Add Pokemon 
                              2.Remove Pokemon 
                              3.
                              4.
                              """);                             //Menu som jeg skal ha
            
            var input =  Console.ReadLine();           // input switch func
            switch (input)                                  // add pokemon
            {                                               // var input = Console.ReadKey()      
                case "1":                                   // switch(input.Key)  dette er direkte bruk
                    Addpokemon();
                    break;

                case "2":
                    //RemPokemon();                           //Remove a pokemon
                    break;

                default: break;

            }

        }

        private void Addpokemon()                   // legger til Pokemon funksjon 
        {
            Console.WriteLine("Name of said pokemon =)");               //spør om navn du skal skrive inn
            var name = Console.ReadLine();                              //skriv in navn
            var type = Console.ReadLine();                       //ossen type/element pokemon er    
            var level = int.Parse(Console.ReadLine());              //level på pokemon
            var Abilities = Console.ReadLine();                  //Abilities pokemon du legger til har
            _pokemons.Add(new Pokemon(name, type, level, Abilities));   //pokemon  "stats/info"
            Console.WriteLine(_pokemons[0].Name);                       //pokemon med index pg navn den skriver in 
        }

        //private void RemPokemon()
        //{
        //    Console.WriteLine("Witch pokemon to release");         // List med pokemon jeg har og hvem skal bort 
        //    _pokemons.Remove();                                    // Skal få lagd en print liste av hvem jeg har og valgt hvem skal ut

        //}

    }
}
