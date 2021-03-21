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
        public override string ToString()
        {
            return GetType().Name;
        }
    }

    public class Bat : Hazard
    {
        public void TransportPlayerTo(int roomNumber)
        {
            // TODO: move the player to another room / check to see that it's not the same room as the current room.
            // Should we consider if a hazard already exists in the room to be dropped off in?

        }
    }

    public class Pit : Hazard
    {

    }

    public class Wumpus : Hazard
    {

    }
}
