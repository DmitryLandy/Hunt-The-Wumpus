using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HuntTheWumpus
{
    public static class Map
    {
        private static Random _random = new Random();
        public static List<Room> Rooms { get; set; } = new List<Room>(21);

        public static void PopulateRooms()
        {
           using(var sr = new StreamReader(@"..\..\Resources\RoomConnections.txt"))
            {
                int roomNumber = 0;
                string line = "";
                 while((line = sr.ReadLine()) != null)
                {
                    string [] rooms = line.Split(',');
                    Rooms.Add(new Room(roomNumber) { 
                        ConnectedRooms = new List<int> { 
                            int.Parse(rooms[0]),
                            int.Parse(rooms[1]),
                            int.Parse(rooms[2])
                        } 
                    });
                    roomNumber++;
                }
            }
           
        }

        public static void GenerateHazard()
        {
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
                if (Rooms[randomRoomNum].Hazard == null)
                {
                    Rooms[randomRoomNum].Hazard = hazards.Pop();
                }
            }
        }
    }
}
