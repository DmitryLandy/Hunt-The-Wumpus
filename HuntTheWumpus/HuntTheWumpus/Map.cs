using System.Collections.Generic;

namespace HuntTheWumpus
{
    public static class Map
    {
        public static List<Room> Rooms { get; set; } = new List<Room>(21); // ProvideRooms();

        public static void PopulateRooms()
        {
            Rooms.Add(new Room() { ConnectedRooms = new List<int> { 0, 0, 0 } }); // Room 0
            Rooms.Add(new Room() { ConnectedRooms = new List<int> { 1, 2, 3 } }); // Room 1
            // more to add
        }

        public static void GenerateHazard()
        {
            // TODO:
        }

    }
}
