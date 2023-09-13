using System;
using System.Collections.Generic;

namespace Lists_Babcock_Olivia
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            // Creates new list and string for games.
            List<string> games = new List<string>
            {
                "Halo 2",
                "Sonic Adventure 2",
                "SW: KotOR",
                "Mortal Kombat: Deception",
                "Pokemon Platinum"
            };
            // Creates another string for otherGames.
            string[] otherGames = new string[]
            {
                "Call of Duty 2",
                "Super Mario Sunshine"
            };
            // Sets a foreach loop in games.
            foreach(string game in games)
            {   // Prints game(s) to the console.
                Console.WriteLine(game);
            }

            // Displays the number of games in the list to the console.
            Console.WriteLine($"\nGames in list: {games.Count}");

            // Creates range for otherGames.
            games.AddRange(otherGames);

            // Displays the number of games in the list to the console.
            Console.WriteLine($"\nGames in list: {games.Count}");

            // Creates an if and else statement and it's parameters.
            if (games.Contains("Halo"))
            {   // Prints to the console.
                Console.WriteLine("\nMASTER CHIEF IS IN THE HOUSE!!");
            }
            else
            {
                // Adds Halo to the list.
                games.Add("Halo");
            }

            // Sets myInt to 6.
            int myInt = 6;

            // Creates an if and else statement and it's parameters.
            if(myInt < games.Count)
            {   
                // Removes myInt element.
                games.RemoveAt(myInt);
            }
            else
            {   
                // Prints to the console.
                Console.WriteLine("\nGame not found!");
            }

            // States all games in the list and prints to the console.
            Console.WriteLine("\nAll games in the list:");
            // Sets foreach loop in games.
            foreach (string game in games)
            {   
                // Prints game to the console.
                Console.WriteLine(game);
            }

            // Sorts games.
            games.Sort();
            // Prints to the console.
            Console.WriteLine("\nSorted games list:");
            // Sets foreach loop in games.
            foreach (string game in games)
            {   // Prints game to the console.
                Console.WriteLine(game);
            }

            // Defines newList string.
            string[] newList = new string[games.Count];

            // Copies games to new list.
            games.CopyTo(newList);

            // Clears games
            games.Clear();

            // Prints to the console
            Console.WriteLine("\nNew List:");
            // Sets foreach loop in newList
            foreach (string game in newList)
            {   
                // Prints games to the console.
                Console.WriteLine(game);
            }
        }
    }
}