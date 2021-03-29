using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuntTheWumpus
{
    public class Room
    {
        public int RoomNumber { get; set; }
        public List<int> ConnectedRooms { get; set; } = new List<int>(3);

        public Hazard Hazard { get; set; }

        public Room(int roomNumber)
        {
            RoomNumber = roomNumber;
        }
    }

   
}
