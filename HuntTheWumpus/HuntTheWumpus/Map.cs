using System;
using System.Collections.Generic;
using System.Linq;

namespace HuntTheWumpus
{
    public static class Map
    {
        private static Random _random = new Random();
        public static List<Room> Rooms { get; set; } = new List<Room>(21); // ProvideRooms();

        public static void PopulateRooms()
        {
            Rooms.Add(new Room() { ConnectedRooms = new List<int> { 0, 0, 0 } }); // Room 0
            Rooms.Add(new Room() { ConnectedRooms = new List<int> { 2, 3, 4 } }); // Room 1
            Rooms.Add(new Room() { ConnectedRooms = new List<int> { 1, 6, 7 } }); // Room 2
            Rooms.Add(new Room() { ConnectedRooms = new List<int> { 1, 8, 17 } }); // Room 3
            Rooms.Add(new Room() { ConnectedRooms = new List<int> { 1, 8, 5 } }); // Room 4
            Rooms.Add(new Room() { ConnectedRooms = new List<int> { 4, 6, 11 } }); // Room 5
            Rooms.Add(new Room() { ConnectedRooms = new List<int> { 2, 5, 9 } }); // Room 6
            Rooms.Add(new Room() { ConnectedRooms = new List<int> { 2, 9, 18 } }); // Room 7
            Rooms.Add(new Room() { ConnectedRooms = new List<int> { 3, 4, 10 } }); // Room 8
            Rooms.Add(new Room() { ConnectedRooms = new List<int> { 6, 7, 12 } }); // Room 9
            Rooms.Add(new Room() { ConnectedRooms = new List<int> { 8, 11, 13 } }); // Room 10
            Rooms.Add(new Room() { ConnectedRooms = new List<int> { 5, 10, 12 } }); // Room 11
            Rooms.Add(new Room() { ConnectedRooms = new List<int> { 9, 11, 14 } }); // Room 12
            Rooms.Add(new Room() { ConnectedRooms = new List<int> { 10, 17, 15 } }); // Room 13
            Rooms.Add(new Room() { ConnectedRooms = new List<int> { 12, 16, 18 } }); // Room 14
            Rooms.Add(new Room() { ConnectedRooms = new List<int> { 13, 16, 19 } }); // Room 15
            Rooms.Add(new Room() { ConnectedRooms = new List<int> { 14, 15, 20 } }); // Room 16
            Rooms.Add(new Room() { ConnectedRooms = new List<int> { 3, 13, 19 } }); // Room 17
            Rooms.Add(new Room() { ConnectedRooms = new List<int> { 7, 14, 20 } }); // Room 18
            Rooms.Add(new Room() { ConnectedRooms = new List<int> { 15, 17, 20 } }); // Room 19
            Rooms.Add(new Room() { ConnectedRooms = new List<int> { 7, 14, 20 } }); // Room 20
        }

        public static void GenerateHazard()
        {
            // TODO:
            // int index = _random.Next(1, 21);
            Stack<Hazard> hazards = new Stack<Hazard>();

            hazards.Push(new Bat());
            hazards.Push(new Bat());
            hazards.Push(new Bat());
            hazards.Push(new Pit());
            hazards.Push(new Pit());
            hazards.Push(new Wumpus());

            while (hazards.Count != 0)
            {
                int randomRoomNum = _random.Next(1, 21);
                if (Rooms.ElementAt(randomRoomNum).Hazard == null)
                {
                    Rooms.ElementAt(randomRoomNum).Hazard = hazards.Pop();
                }
            }

        }
    }
}
