using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuntTheWumpus
{
    public abstract class Hazard
    {
        // TODO:  Create a class for Bat, Pit, and Wumpus and derive it from Hazard
        // Hazard will serve as a collection template
        public string Warning { get; set; } = "Hazard Nearby";
        public override string ToString()
        {
            return GetType().Name;
        }
    }

    public class Bat : Hazard
    {
        public Bat() { Warning = "The player hears the flapping of a bat's wings."; }
        public void TransportPlayer(Player player)
        {
            
            
            Random r = new Random();
            
            int targetRoom = r.Next(1, 21);
            Hazard hazard = Map.Rooms.ElementAt(targetRoom).Hazard;
            if (hazard == null)
            {
                Console.WriteLine($"Bat has swept you to a room {targetRoom}!");
                Console.ReadKey();
                player.MoveTo(targetRoom);
            }
            else
            {
                TransportPlayer(player);
            }
            // TODO: move the player to another room / check to see that it's not the same room as the current room.
            // Should we consider if a hazard already exists in the room to be dropped off in?

        }
    }

    public class Pit : Hazard
    {
        public Pit() { Warning = "The player feels the draft from a pit nearby."; }
    }

    public class Wumpus : Hazard
    {

        public Wumpus() { Warning = "The player smells the stench of Wumpus."; }
    }
}
