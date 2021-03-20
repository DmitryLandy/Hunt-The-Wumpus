using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuntTheWumpus
{
    class Player
    {
        public bool IsAlive { get; set; } // up for further debate
        public Room CurrentLocation { get; set; }

        public void ShootAt(int roomNumber)
        {
            if (Map.Rooms.ElementAt(roomNumber).Hazard is Wumpus)
            {
                Console.WriteLine("You are a winner! Congratulations!");
            }
            else
            {
                Console.WriteLine("You are a loser!  Game over!");
            }
        }

        public Hazard MoveTo(int roomNumber)
        {
            // TODO: set the player postion to the new room with roomNumber
            // TODO: display all the hazards

            Room room = Map.Rooms.ElementAt(roomNumber);

            if (room.Hazard != null)
                return room.Hazard;
            else
                return null;
        }
    }
}
