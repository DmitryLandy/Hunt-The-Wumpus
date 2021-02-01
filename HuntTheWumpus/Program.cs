using System;
using System.IO;

namespace HuntTheWumpus
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayRules();
            DisplayMap();
        }

        static void DisplayRules()
        {
            string rules = File.ReadAllText(@"SupportFiles\wumpus.txt");
            Console.WriteLine(rules);
            PauseAndCleanUp();
        }

        static void DisplayMap()
        {
            string rules = File.ReadAllText(@"SupportFiles\map.txt");
            Console.WriteLine(rules);
            PauseAndCleanUp();
        }

        static void PauseAndCleanUp()
        {
            Console.WriteLine("\n\n\n\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
