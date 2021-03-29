using System;
using System.Linq;

namespace HuntTheWumpus
{
    public class Player
    {
        public bool IsAlive { get; set; } // up for further debate
        public Room CurrentLocation { get; set; }

        public void ShootAt(int roomNumber)
        {
            if (Map.Rooms[roomNumber].Hazard is Wumpus)
            {
                Console.WriteLine("You are a winner! Congratulations! Press any key to continue");
                Console.ReadKey();
                Game.Init();
            }
            else
            {
                
                Console.WriteLine("You are a loser!  Game over! Press any key to continue");
                Console.ReadKey();
                Game.Init();
            }
        }

        public void MoveTo(int roomNumber)
        {
            CurrentLocation = Map.Rooms[roomNumber];
            Hazard hazard = Map.Rooms.ElementAt(roomNumber).Hazard;

<<<<<<< HEAD
            if (hazard is Bat b)
            {
                b.TransportPlayer(this);
            }
            else if (hazard is Wumpus)
            {
                IsAlive = false;
            }
            else if (hazard is Pit)
            {
                IsAlive = false;
            }
=======
            Room room = Map.Rooms[roomNumber];

            if (room.Hazard != null)
                return room.Hazard;
            else
                return null;
>>>>>>> bb99ab727e2742e64eba5cb2d1cfa3f1c94aa753
        }
    }
}
