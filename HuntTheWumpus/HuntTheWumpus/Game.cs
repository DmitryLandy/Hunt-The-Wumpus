﻿using System;
using System.Linq;

namespace HuntTheWumpus
{
    public class Game
    {
        public static void Start()
        {
            Map.PopulateRooms();
            Map.GenerateHazard();
            #region Testing
            /* For testing purpose only
            foreach (var room in Map.Rooms)
            {
                room.ConnectedRooms.ForEach(r => Console.Write($"{r} "));
                Console.WriteLine(room.Hazard);
                Console.ReadLine();
            }
            */
            #endregion
            // Add additional methods to initialize the game
        }

        public static void DisplayHazardsNearby(int roomNumber)
        {
            Room room = Map.Rooms.ElementAt(roomNumber);

            foreach (var rm in room.ConnectedRooms)
            {
                // check for hazard in each of the connected rooms
                if (Map.Rooms.ElementAt(rm).Hazard is Wumpus)
                    Console.WriteLine("The player smells the stench of Wumpus.");
                else if (Map.Rooms.ElementAt(rm).Hazard is Pit)
                    Console.WriteLine("The player feels the draft from a pit nearby.");
                else
                    Console.WriteLine("The player hears the flapping of a bat's wings.");
            }
        }

    }
}
