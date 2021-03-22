using System;
using System.Linq;

namespace HuntTheWumpus
{
    public static class Game
    {
        public static void Start()
        {
            Map.PopulateRooms();
            Map.GenerateHazard();
            #region Testing
            // For testing purpose only
            foreach (var room in Map.Rooms)
            {
                Console.Write($"Room #: {Map.Rooms.IndexOf(room):00}     Connected Rooms: ");
                room.ConnectedRooms.ForEach(r => Console.Write($"{r:00} "));
                Console.WriteLine($"     Hazard Present: {room.Hazard}");
            }

            Console.ReadLine();
            // The end of testing
            #endregion

            // Add additional methods to initialize the game
        }

        public static int menu(int selection = 0)
        { 
            
           
           Console.WriteLine("Welcome to Hunt the Wumpus. Please select an option " +
              "1 for rules, 2 to play, 3 to exit");
            int.TryParse(Console.ReadLine(),out selection);
            switch(selection)
                {
                case 1:
                    displayRules();
                    break;
                case 2:
                    Start();
                    break;
                    
                case 3:
                    Exit();
                    break;

                }
            return selection;
        }

        private static void Exit()
        {
            Console.WriteLine("Goodbye chicken.");
        }

        private static void displayRules()
        {
            Console.WriteLine("One player, armed with an M4 Carbine with ONE(1) bullet" +
                "\nFirearm range is one cavern only, but hits are guaranteed" +
                "\nOne Wumpus, who does not move, with stench only in the adjacent caverns" +
                "\nAs many caverns as desired, possibly player configurable, with any number of tunnels(i.e., does not have to be 3)" +
                "\nAs many bats as desired, with chirps only in the adjacent caverns, possibly player configurable" +
                "\nAs many pits as desired, with drafts only in the adjacent caverns, possibly player configurable" +
                "\nWinning: shooting the Wumpus" +
                "\nLosing: falling into a pit, shooting into the wrong cavern, entering the Wumpus cavern without shooting");

        }

        public static void DisplayHazardsNearby(int roomNumber)
        {
            Room room = Map.Rooms[roomNumber];

            foreach (var roomNum in room.ConnectedRooms)
            {
                switch (Map.Rooms[roomNum].Hazard)
                {
                    case Wumpus _:
                        Console.WriteLine("The player smells the stench of Wumpus.");
                        break;
                    case Pit _:
                        Console.WriteLine("The player feels the draft from a pit nearby.");
                        break;
                    case Bat _:
                        Console.WriteLine("The player hears the flapping of a bat's wings.");
                        break;
                }

                /* Alternative way to do type checking
                if (Map.Rooms.ElementAt(rm).Hazard is Wumpus)
                    Console.WriteLine("The player smells the stench of Wumpus.");
                else if (Map.Rooms.ElementAt(rm).Hazard is Pit)
                    Console.WriteLine("The player feels the draft from a pit nearby.");
                else if (Map.Rooms.ElementAt(rm).Hazard is Bat)
                    Console.WriteLine("The player hears the flapping of a bat's wings.");
                */
            }
        }

    }
}
