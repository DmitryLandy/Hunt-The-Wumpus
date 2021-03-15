using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuntTheWumpus
{
    class Player
    {
        public bool IsAlive { get; set; }
        

        public void ShootAt(int roomNumber)
        {
            List<Hazard> hazards = getHazardsNearby(roomNumber);

            if (hazards.Count > 0)
            {
                foreach (var hazard in hazards)
                {
                    if (!(hazard is Wumpus))
                    {
                        Console.WriteLine("You are a loser!  Game over!");
                        // Add End game interface to ask the player if he/she wants
                        // to play again or quit
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You are a winner! Congratulations!");
                    }
                }
            }
        }

        public void MoveTo(int roomNumber)
        {
            // TODO: set the player postion to the new room with roomNumber
            // TODO: display all the hazards

            List<Hazard> hazards = getHazardsNearby(roomNumber);

            string result = "";

            if (hazards.Count > 0)
            {
                foreach (var hazard in hazards)
                {
                    if (!(hazard is Bat))
                    {
                        Console.WriteLine("You are a loser!  Game over!");
                        break;
                    }
                    else
                    {
                        // TODO: Bat moves the player to another room
                        // return MoveTo(randomNumber) to be assigned from outside class
                        // ensure that randomNumber is NOT the same as the roomNumber
                    }
                }
            }

            senseHazards();
        }

        private void senseHazards()
        {
            // TODO: Loop nearbyRooms list to get the hazards
            // TODO: If hazards, then print to screen
        }

        private List<Hazard> getHazardsNearby(int roomNumber)
        {
            Room room = Map.Rooms.ElementAt(roomNumber);

            foreach (var rm in room.ConnectedRooms)
            {
                // check for hazard in each of the connected rooms
                foreach (var hazard in Map.Rooms.ElementAt(rm).Hazards)
                {
                    if (hazard is Wumpus)
                    {
                        
                    }
                }
                ;
                

                if (true)
                {

                }

                Console.WriteLine(rm);

            }
            

        }

        

        /*
        

        */
    }
}
