using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace FriendFace
{
    internal record Friends()
    {
        private List<Friends> _friends = new List<Friends>();
        
        public void Run() // Denne bør flyttes til Program.cs
        {
            Console.WriteLine("Velkommen til Friend Face");     //Gjør at du kan lage venne liste i terminalen
            while (true)
            {
                Console.WriteLine("""
                                  
                                  CTRL + C (forlatt meny)
                                  1. Legg til Venn
                                  2. Vis venner
                                  3. Fjern "Venn"
                                  4. se Online status
                                  5. Logg av FriendFace
                                  """);                     //Meny valg

               var input = Console.ReadLine();             //dette blir da en switch funksjon
                
                switch (input)                              // trur dette vil funke 
                {
                    case "1":
                        Console.Write("Skriv inn Navn: ");
                        string name = Console.ReadLine();
                        Console.Write("Din Venn's alder: ");
                        string age = Console.ReadLine();
                        Console.WriteLine("Vedkommenes navn er " + name + " vedkommende alder er "  + age + "år"); // Skal lagt til en syntax for legge til
                        break;

                    case "2":
                        Console.WriteLine("Venner du har online");
                       // Console.WriteLine($"{friendslist}"); // lage venneliste så denne funker 
                        
                        //ShowFriends();                     //skal printe ut en liste av venner 
                        break;

                    case "3":
                        //RemoveFriend();                   //fjerene "venner" fra liste 
                        break;

                    case "4":
                        Console.WriteLine($"*Pålogget*");   // For og se hvem som er pålogget
                        break;

                    case "5":
                        Process.Start("devenv.exe", "/command File.Exit");                                                           // Avslutte console
                        break;

                }
            }
        }

        private void AddFriend()
        {
            AddFriend(_friends);
        }

        private void AddFriend(List<Friends> friends)         // Legg til en venn funksjon
        {
            Console.WriteLine("Name of said friend you have");
            var name = Console.ReadLine();      //Skriv in Navn på "venn"
            var gender = Console.ReadLine();    //Skriv in kjønn           

        }
    }
}
