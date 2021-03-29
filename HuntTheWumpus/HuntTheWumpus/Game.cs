using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HuntTheWumpus
{
    public static class Game
    {
        public static Player Player { get; set; } = new Player();
        public static void Init()
        {
            Map.PopulateRooms();
            Map.GenerateHazard();
            Player.CurrentLocation = Map.Rooms[1];
            Player.IsAlive = true;
            ShowMenu();
        }

        public static void Start()
        {
            
            while (Player.IsAlive)
            {
                Console.Clear();
                List<Hazard> Hazards = new List<Hazard>();
                int[] connectedRooms = Player.CurrentLocation.ConnectedRooms.ToArray();
                
                Console.WriteLine($"YOU ARE IN ROOM {Player.CurrentLocation.RoomNumber}");
                Console.Write($"TUNNELS LEAD TO ");
                foreach (int n in Player.CurrentLocation.ConnectedRooms)
                {
                    Hazard hazard = Map.Rooms.ElementAt(n).Hazard;
                    if (hazard != null)
                    {
                        Hazards.Add(hazard);
                    }
                    Console.Write($"{n} ");
                }
                Console.WriteLine();
                if (Hazards.Count !=0 )
                {
                    Console.WriteLine("THE FOLLOWING HAZARDS ARE NEARBY: ");
                    foreach (Hazard hazard in Hazards)
                    {
                        Console.WriteLine($"\t{hazard.Warning}");
                    }
                }

                string selection = UserInput.MoveOrShoot();
                Console.Write($"WHICH ROOM [{connectedRooms[0]}, " +
                            $"{ connectedRooms[1]}, " +
                            $"{connectedRooms[2]}] ?: ");
                int target = UserInput.GetTarget(connectedRooms);
                Console.WriteLine();
                switch (selection)
                {
                    case "S":
                        Player.ShootAt(target);
                        break;
                    case "M":
                        Player.MoveTo(target);
                        break;
                }
            }
            Console.WriteLine($"Sorry {Player.CurrentLocation.Hazard} was in room. You Died");
            Console.ReadKey();
            Init();


            //#region Testing
            //// For testing purpose only
            //foreach (var room in Map.Rooms)
            //{
            //    Console.Write($"Room #: {Map.Rooms.IndexOf(room):00}     Connected Rooms: ");
            //    room.ConnectedRooms.ForEach(r => Console.Write($"{r:00} "));
            //    Console.WriteLine($"     Hazard Present: {room.Hazard}");
            //}

            //Console.ReadLine();
            //// The end of testing
            //#endregion

            // Add additional methods to initialize the game
<<<<<<< HEAD
        }

        public static void ShowMenu()
        {
            Console.Clear();
            try
            {
                using (var sr = new StreamReader("..\\..\\Resources\\Menu.txt"))
                {
                    Console.WriteLine(sr.ReadToEnd());
                    Console.Write("Selection: ");
                    int selection = UserInput.GetInteger(1, 3);
                    switch (selection)
                    {
                        case 1:
                            DisplayRules();
                            break;
                        case 2:
                            Start();
                            break;
                        case 3:
                            Exit();
                            break;
                    }
                }
                
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File Not Found");
            }
        }

        private static void Exit()
        {
            Console.WriteLine("Goodbye chicken.");
            Console.ReadKey();
            Environment.Exit(0);
        }

        private static void DisplayRules()
        {

            Console.Clear();
            try
            {
                using (var sr = new StreamReader("..\\..\\Resources\\Rules.txt"))
                {

                    Console.WriteLine(sr.ReadToEnd());
                    Console.Write("Press any key to go back to menu: ");
                    Console.ReadKey();
                    ShowMenu();
                }

            }
            catch (FileNotFoundException e)
            {

                Console.WriteLine("File Not Found");
=======
        }

        public static int menu(int selection = 0)
        { 
            
           
           Console.WriteLine("Welcome to Hunt the Wumpus. Please select an option " +
              "1 for rules, 2 to play, 3 to exit");
            int.TryParse(Console.ReadLine(),out selection);
            switch(selection)
                {
                case 1:
                    displayRules();
                    break;
                case 2:
                    Start();
                    break;
                    
                case 3:
                    Exit();
                    break;

                }
            return selection;
        }

        private static void Exit()
        {
            Console.WriteLine("Goodbye chicken.");
        }

        private static void displayRules()
        {
            Console.WriteLine("One player, armed with an M4 Carbine with ONE(1) bullet" +
                "\nFirearm range is one cavern only, but hits are guaranteed" +
                "\nOne Wumpus, who does not move, with stench only in the adjacent caverns" +
                "\nAs many caverns as desired, possibly player configurable, with any number of tunnels(i.e., does not have to be 3)" +
                "\nAs many bats as desired, with chirps only in the adjacent caverns, possibly player configurable" +
                "\nAs many pits as desired, with drafts only in the adjacent caverns, possibly player configurable" +
                "\nWinning: shooting the Wumpus" +
                "\nLosing: falling into a pit, shooting into the wrong cavern, entering the Wumpus cavern without shooting");

        }

        public static void DisplayHazardsNearby(int roomNumber)
        {
            Room room = Map.Rooms[roomNumber];

            foreach (var roomNum in room.ConnectedRooms)
            {
                switch (Map.Rooms[roomNum].Hazard)
                {
                    case Wumpus _:
                        Console.WriteLine("The player smells the stench of Wumpus.");
                        break;
                    case Pit _:
                        Console.WriteLine("The player feels the draft from a pit nearby.");
                        break;
                    case Bat _:
                        Console.WriteLine("The player hears the flapping of a bat's wings.");
                        break;
                }

                /* Alternative way to do type checking
                if (Map.Rooms.ElementAt(rm).Hazard is Wumpus)
                    Console.WriteLine("The player smells the stench of Wumpus.");
                else if (Map.Rooms.ElementAt(rm).Hazard is Pit)
                    Console.WriteLine("The player feels the draft from a pit nearby.");
                else if (Map.Rooms.ElementAt(rm).Hazard is Bat)
                    Console.WriteLine("The player hears the flapping of a bat's wings.");
                */
>>>>>>> bb99ab727e2742e64eba5cb2d1cfa3f1c94aa753
            }


            //Console.WriteLine("One player, armed with an M4 Carbine with ONE(1) bullet" +
            //    "\nFirearm range is one cavern only, but hits are guaranteed" +
            //    "\nOne Wumpus, who does not move, with stench only in the adjacent caverns" +
            //    "\nAs many caverns as desired, possibly player configurable, with any number of tunnels(i.e., does not have to be 3)" +
            //    "\nAs many bats as desired, with chirps only in the adjacent caverns, possibly player configurable" +
            //    "\nAs many pits as desired, with drafts only in the adjacent caverns, possibly player configurable" +
            //    "\nWinning: shooting the Wumpus" +
            //    "\nLosing: falling into a pit, shooting into the wrong cavern, entering the Wumpus cavern without shooting");

        }

        //public static void DisplayHazardsNearby(int roomNumber)
        //{
        //    Room room = Map.Rooms[roomNumber];

        //    foreach (var roomNum in room.ConnectedRooms)
        //    {
        //        switch (Map.Rooms[roomNum].Hazard)
        //        {
        //            case Wumpus _:
        //                Console.WriteLine("The player smells the stench of Wumpus.");
        //                break;
        //            case Pit _:
        //                Console.WriteLine("The player feels the draft from a pit nearby.");
        //                break;
        //            case Bat _:
        //                Console.WriteLine("The player hears the flapping of a bat's wings.");
        //                break;
        //        }

        //        /* Alternative way to do type checking
        //        if (Map.Rooms.ElementAt(rm).Hazard is Wumpus)
        //            Console.WriteLine("The player smells the stench of Wumpus.");
        //        else if (Map.Rooms.ElementAt(rm).Hazard is Pit)
        //            Console.WriteLine("The player feels the draft from a pit nearby.");
        //        else if (Map.Rooms.ElementAt(rm).Hazard is Bat)
        //            Console.WriteLine("The player hears the flapping of a bat's wings.");
        //        */
        //    }
        //}

    }
}