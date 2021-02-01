using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuntTheWsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] huntinggrounds = InitBoard();
            Player test=InitPlayer();
            //PrintBoard(huntinggrounds);
            huntinggrounds=updateBoard(huntinggrounds, test);
            PrintBoard(huntinggrounds);
            CalculateRoomsCoords(huntinggrounds, test);
            //string myhealths=test.CurrentHealth.ToString();
            //int.TryParse(myhealths, out int myhealth);
            //Console.WriteLine($"My players current health is {myhealth}");
            while (test.CurrentHealth != 0)
            {
                test=UpdatePlayer(huntinggrounds, test);
                huntinggrounds = updateBoard(huntinggrounds, test);
                PrintBoard(huntinggrounds);
            }
        }

        private static Player UpdatePlayer(string[,] board, Player hunter)
        {

            //updateBoard(board, hunter);
            Console.WriteLine("what action do you want to do, you can move, shoot or check map");
            string input = Console.ReadLine();
            if (input == "move")
            {
                //hunter.CurrentPlayerX
                //CalculateRoomsFromCurrentPos(board, hunter);
                //GIANT if statement to determine where the player can go based on their current position
                if (hunter.CurrentPlayerX == 0 && hunter.CurrentPlayerY == 2)
                {
                    Console.WriteLine("You are in room 1");
                    Console.WriteLine("You can choose room 2, room 3, and room 4");
                    input = Console.ReadLine();
                    if (input == "room 3")
                    {
                        hunter.CurrentPlayerX = 2;
                        hunter.CurrentPlayerY = 0;
                    }
                    else if(input == "room 4")
                    {
                        hunter.CurrentPlayerX = 2;
                        hunter.CurrentPlayerY = 4;
                    }
                    else if (input == "room 2")
                    {
                        hunter.CurrentPlayerX = 0;
                        hunter.CurrentPlayerY = 10;
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid input");
                    }
                }
                else if (hunter.CurrentPlayerX == 0 && hunter.CurrentPlayerY == 10)
                {
                    Console.WriteLine("You are in room 2");
                    Console.WriteLine("You can choose room 1, room 6, and room 7 ");
                    input = Console.ReadLine();
                    if (input== "room 1")
                    {
                        hunter.CurrentPlayerX = 0;
                        hunter.CurrentPlayerY = 2;
                    }
                    else if(input == "room 6")
                    {
                        hunter.CurrentPlayerX = 2;
                        hunter.CurrentPlayerY = 8;
                    }
                    else if(input == "room 7")
                    {
                        hunter.CurrentPlayerX = 2;
                        hunter.CurrentPlayerY = 12;
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid input");
                    }
                }
                else if (hunter.CurrentPlayerX == 2 && hunter.CurrentPlayerY == 0)
                {
                    Console.WriteLine("You are in room 3");
                    Console.WriteLine("You can choose room 1, room 8, and room 15");
                    input = Console.ReadLine();
                    if (input == "room 1")
                    {
                        hunter.CurrentPlayerX = 0;
                        hunter.CurrentPlayerY = 2;
                    }
                    else if (input == "room 8")
                    {
                        hunter.CurrentPlayerX = 4;
                        hunter.CurrentPlayerY = 2;
                    }
                    else if (input == "room 15")
                    {
                        hunter.CurrentPlayerX = 10;
                        hunter.CurrentPlayerY = 0;
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid input");
                    }
                }
                else if (hunter.CurrentPlayerX == 2 && hunter.CurrentPlayerY == 4)
                {
                    Console.WriteLine("You are in room 4");
                    Console.WriteLine("You can choose room 1, room 5, and room 8");
                    input = Console.ReadLine();
                    if (input == "room 1")
                    {
                        hunter.CurrentPlayerX = 0;
                        hunter.CurrentPlayerY = 2;
                    }
                    else if (input == "room 5")
                    {
                        hunter.CurrentPlayerX = 2;
                        hunter.CurrentPlayerY = 6;
                    }
                    else if (input == "room 8")
                    {
                        hunter.CurrentPlayerX = 4;
                        hunter.CurrentPlayerY = 2;
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid input");
                    }
                }
                else if (hunter.CurrentPlayerX == 2 && hunter.CurrentPlayerY == 6)
                {
                    Console.WriteLine("You are in room 5");
                    Console.WriteLine("You can choose room 4, room 6, and room 11");
                    input = Console.ReadLine();
                    if (input == "room 4")
                    {
                        hunter.CurrentPlayerX = 2;
                        hunter.CurrentPlayerY = 4;
                    }
                    else if (input == "room 6")
                    {
                        hunter.CurrentPlayerX = 2;
                        hunter.CurrentPlayerY = 8;
                    }
                    else if (input == "room 11")
                    {
                        hunter.CurrentPlayerX = 6;
                        hunter.CurrentPlayerY = 6;
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid input");
                    }
                }
                else if (hunter.CurrentPlayerX == 2 && hunter.CurrentPlayerY == 8)
                {
                    Console.WriteLine("You are in room 6");
                    Console.WriteLine("You can choose room 2, room 5, and room 9");
                    input = Console.ReadLine();
                    if (input == "room 2")
                    {
                        hunter.CurrentPlayerX = 0;
                        hunter.CurrentPlayerY = 10;
                    }
                    else if (input == "room 5")
                    {
                        hunter.CurrentPlayerX = 2;
                        hunter.CurrentPlayerY = 6;
                    }
                    else if (input == "room 9")
                    {
                        hunter.CurrentPlayerX = 4;
                        hunter.CurrentPlayerY = 10;
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid input");
                    }
                }
                else if (hunter.CurrentPlayerX == 2 && hunter.CurrentPlayerY == 12)
                {
                    Console.WriteLine("You are in room 7");
                    Console.WriteLine("You can choose room 2, room 9, and room 18");
                    input = Console.ReadLine();
                    if (input == "room 2")
                    {
                        hunter.CurrentPlayerX = 0;
                        hunter.CurrentPlayerY = 10;
                    }
                    else if (input == "room 9")
                    {
                        hunter.CurrentPlayerX = 4;
                        hunter.CurrentPlayerY = 10;
                    }
                    else if (input == "room 18")
                    {
                        hunter.CurrentPlayerX = 10;
                        hunter.CurrentPlayerY = 12;
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid input");
                    }
                }
                else if (hunter.CurrentPlayerX == 4 && hunter.CurrentPlayerY == 2)
                {
                    Console.WriteLine("You are in room 8");
                    Console.WriteLine("You can choose room 3, room 4, and room 10");
                    input = Console.ReadLine();
                    if (input == "room 3")
                    {
                        hunter.CurrentPlayerX = 2;
                        hunter.CurrentPlayerY = 0;
                    }
                    else if (input == "room 4")
                    {
                        hunter.CurrentPlayerX = 2;
                        hunter.CurrentPlayerY = 4;
                    }
                    else if (input == "room 10")
                    {
                        hunter.CurrentPlayerX = 6;
                        hunter.CurrentPlayerY = 2;
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid input");
                    }
                }
                else if (hunter.CurrentPlayerX == 4 && hunter.CurrentPlayerY == 10)
                {
                    Console.WriteLine("You are in room 9");
                    Console.WriteLine("You can choose room 6, room 7, and room 12");
                    input = Console.ReadLine();
                    if (input == "room 6")
                    {
                        hunter.CurrentPlayerX = 2;
                        hunter.CurrentPlayerY = 8;
                    }
                    else if (input == "room 7")
                    {
                        hunter.CurrentPlayerX = 2;
                        hunter.CurrentPlayerY = 12;
                    }
                    else if (input == "room 12")
                    {
                        hunter.CurrentPlayerX = 6;
                        hunter.CurrentPlayerY = 10;
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid input");
                    }
                }
                else if(hunter.CurrentPlayerX == 6 && hunter.CurrentPlayerY == 2)
                {
                    Console.WriteLine("You are in room 10");
                    Console.WriteLine("You can choose room 8, room 11, and room 13");
                    input = Console.ReadLine();
                    if (input == "room 8")
                    {
                        hunter.CurrentPlayerX = 4;
                        hunter.CurrentPlayerY = 2;
                    }
                    else if (input == "room 11")
                    {
                        hunter.CurrentPlayerX = 6;
                        hunter.CurrentPlayerY = 6;
                    }
                    else if (input == "room 13")
                    {
                        hunter.CurrentPlayerX = 8;
                        hunter.CurrentPlayerY = 2;
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid input");
                    }
                }
                else if (hunter.CurrentPlayerX == 6 && hunter.CurrentPlayerY == 6)
                {
                    Console.WriteLine("You are in room 11");
                    Console.WriteLine("You can choose room 5, room 10, and room 12");
                    input = Console.ReadLine();
                    if (input == "room 5")
                    {
                        hunter.CurrentPlayerX = 2;
                        hunter.CurrentPlayerY = 6;
                    }
                    else if (input == "room 10")
                    {
                        hunter.CurrentPlayerX = 6;
                        hunter.CurrentPlayerY = 2;
                    }
                    else if (input == "room 12")
                    {
                        hunter.CurrentPlayerX = 6;
                        hunter.CurrentPlayerY = 10;
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid input");
                    }
                }
                else if (hunter.CurrentPlayerX == 6 && hunter.CurrentPlayerY == 10)
                {
                    Console.WriteLine("You are in room 12");
                    Console.WriteLine("You can choose room 9, room 11, and room 14");
                    input = Console.ReadLine();
                    if (input == "room 9")
                    {
                        hunter.CurrentPlayerX = 4;
                        hunter.CurrentPlayerY = 10;
                    }
                    else if (input == "room 11")
                    {
                        hunter.CurrentPlayerX = 6;
                        hunter.CurrentPlayerY = 6;
                    }
                    else if (input == "room 14")
                    {
                        hunter.CurrentPlayerX = 8;
                        hunter.CurrentPlayerY = 10;
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid input");
                    }
                }
                else if (hunter.CurrentPlayerX == 8 && hunter.CurrentPlayerY == 2)
                {
                    Console.WriteLine("You are in room 13");
                    Console.WriteLine("You can choose room 10, room 15, and room 16");
                    input = Console.ReadLine();
                    if (input == "room 10")
                    {
                        hunter.CurrentPlayerX = 6;
                        hunter.CurrentPlayerY = 2;
                    }
                    else if (input == "room 15")
                    {
                        hunter.CurrentPlayerX = 10;
                        hunter.CurrentPlayerY = 0;
                    }
                    else if (input == "room 16")
                    {
                        hunter.CurrentPlayerX = 10;
                        hunter.CurrentPlayerY = 4;
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid input");
                    }
                }
                else if (hunter.CurrentPlayerX == 8 && hunter.CurrentPlayerY == 10)
                {
                    Console.WriteLine("You are in room 14");
                    Console.WriteLine("You can choose room 12, room 17, and room 18");
                    input = Console.ReadLine();
                    if (input == "room 12")
                    {
                        hunter.CurrentPlayerX = 6;
                        hunter.CurrentPlayerY = 10;
                    }
                    else if (input == "room 17")
                    {
                        hunter.CurrentPlayerX = 10;
                        hunter.CurrentPlayerY = 8;
                    }
                    else if (input == "room 18")
                    {
                        hunter.CurrentPlayerX = 10;
                        hunter.CurrentPlayerY = 12;
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid input");
                    }
                }
                else if(hunter.CurrentPlayerX == 10 && hunter.CurrentPlayerY == 0)
                {
                    Console.WriteLine("You are in room 15");
                    Console.WriteLine("You can choose room 3, room 13, and room 19");
                    input = Console.ReadLine();
                    if (input == "room 3")
                    {
                        hunter.CurrentPlayerX = 2;
                        hunter.CurrentPlayerY = 0;
                    }
                    else if (input == "room 13")
                    {
                        hunter.CurrentPlayerX = 8;
                        hunter.CurrentPlayerY = 2;
                    }
                    else if (input == "room 19")
                    {
                        hunter.CurrentPlayerX = 12;
                        hunter.CurrentPlayerY = 2;
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid input");
                    }
                }
                else if(hunter.CurrentPlayerX == 10 && hunter.CurrentPlayerY == 4)
                {
                    Console.WriteLine("You are in room 16");
                    Console.WriteLine("You can choose room 13, room 17, and room 19");
                    input = Console.ReadLine();
                    if (input == "room 13")
                    {
                        hunter.CurrentPlayerX = 8;
                        hunter.CurrentPlayerY = 2;
                    }
                    else if (input == "room 17")
                    {
                        hunter.CurrentPlayerX = 10;
                        hunter.CurrentPlayerY = 8;
                    }
                    else if (input == "room 19")
                    {
                        hunter.CurrentPlayerX = 12;
                        hunter.CurrentPlayerY = 2;
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid input");
                    }
                }
                else if(hunter.CurrentPlayerX == 10 && hunter.CurrentPlayerY == 8)
                {
                    Console.WriteLine("You are in room 17");
                    Console.WriteLine("You can choose room 14, room 16, and room 20");
                    input = Console.ReadLine();
                    if (input == "room 14")
                    {
                        hunter.CurrentPlayerX = 8;
                        hunter.CurrentPlayerY = 10;
                    }
                    else if (input == "room 16")
                    {
                        hunter.CurrentPlayerX = 10;
                        hunter.CurrentPlayerY = 4;
                    }
                    else if (input == "room 20")
                    {
                        hunter.CurrentPlayerX = 12;
                        hunter.CurrentPlayerY = 10;
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid input");
                    }
                }
                else if(hunter.CurrentPlayerX == 10 && hunter.CurrentPlayerY == 12)
                {
                    Console.WriteLine("You are in room 18");
                    Console.WriteLine("You can choose room 7, room 14, and room 20");
                    input = Console.ReadLine();
                    if (input == "room 7")
                    {
                        hunter.CurrentPlayerX = 2;
                        hunter.CurrentPlayerY = 12;
                    }
                    else if (input == "room 14")
                    {
                        hunter.CurrentPlayerX = 8;
                        hunter.CurrentPlayerY = 10;
                    }
                    else if (input == "room 20")
                    {
                        hunter.CurrentPlayerX = 12;
                        hunter.CurrentPlayerY = 10;
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid input");
                    }
                }
                else if(hunter.CurrentPlayerX == 12 && hunter.CurrentPlayerY == 2)
                {
                    Console.WriteLine("You are in room 19");
                    Console.WriteLine("You can choose room 15, room 16, and room 20");
                    input = Console.ReadLine();
                    if (input == "room 15")
                    {
                        hunter.CurrentPlayerX = 10;
                        hunter.CurrentPlayerY = 0;
                    }
                    else if (input == "room 16")
                    {
                        hunter.CurrentPlayerX = 10;
                        hunter.CurrentPlayerY = 4;
                    }
                    else if (input == "room 20")
                    {
                        hunter.CurrentPlayerX = 12;
                        hunter.CurrentPlayerY = 10;
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid input");
                    }
                }
                else if(hunter.CurrentPlayerX == 12 && hunter.CurrentPlayerY == 10)
                {
                    Console.WriteLine("You are in room 20");
                    Console.WriteLine("You can choose room 17, room 18, and room 19");
                    input = Console.ReadLine();
                    if (input == "room 17")
                    {
                        hunter.CurrentPlayerX = 10;
                        hunter.CurrentPlayerY = 8;
                    }
                    else if (input == "room 18")
                    {
                        hunter.CurrentPlayerX = 10;
                        hunter.CurrentPlayerY = 12;
                    }
                    else if (input == "room 19")
                    {
                        hunter.CurrentPlayerX = 12;
                        hunter.CurrentPlayerY = 2;
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid input");
                    }
                }
                else
                {
                    Console.WriteLine("YOU ARE NOT IN A ROOM COORDINATE WTF");
                }
            }
            else
            {
                Console.WriteLine("Please try again that is not a valid action");
            }
            //we can make a legal move
            
            return hunter;
        }

        private static void CalculateRoomsCoords(string[,] board, Player hunter)
        {
            int rowcount, columncount,roomnum;
            roomnum = 1;
            for (rowcount = 0; rowcount < 13; rowcount++)
            {
                for (columncount = 0; columncount < 13; columncount++)
                {
                    if (board[rowcount,columncount]=="R" || board[rowcount,columncount]=="P")
                    {
                        Console.WriteLine($"Room Coordinate is Room{roomnum}, x is {rowcount} and y is {columncount} ");
                        roomnum++;
                    }
                }
            }
        }

        private static string[,] updateBoard(string[,] board, Player hunter)
        {
            int rowcount, columncount;
            for (rowcount = 0; rowcount < 13; rowcount++)
            {
                for (columncount = 0; columncount < 13; columncount++)
                {
                    //Removes the previus player P
                    if (board[rowcount, columncount] == "P")
                    {
                        board[rowcount, columncount] = "R";
                    }
                    //Adds P to players new coordinates
                    if (hunter.CurrentPlayerX==rowcount && hunter.CurrentPlayerY == columncount)
                    {
                        board[rowcount, columncount] = "P";
                    }
                }
            }
            return board;
        }

        private static string[,] InitBoard()
        {
            int row, column;
            int room = 1;
            string[,] arena = new string[13, 13];
            for (row = 0; row < 13; row++)
            {
                for (column = 0; column < 13; column++)
                {
                    if (row == 0)
                    {
                        //R is rooms, |/\= are tunnels
                        if (column == 2 || column == 10)
                        {
                            arena[row, column] = "R";
                        }
                        else if (column == 2 || column == 3 || column == 4 || column == 5 || column == 6 || column == 7 || column == 8 || column == 9)
                        {
                            arena[row, column] = "=";
                        }
                        else
                        {
                            arena[row, column] = " ";
                        }
                    }
                    else if (row == 1) //adds diagonal tunnesl part 1
                    {
                        if (column == 1 || column == 9)
                        {
                            arena[row, column] = "/";
                        } else if (column == 3 || column == 11)
                        {
                            arena[row, column] = "\\";
                        }
                        else
                        {
                            arena[row, column] = " ";
                        }
                    }
                    else if (row == 2)
                    {
                        if (column == 0 || column == 4 || column == 6 || column == 8 || column == 12)//rooms
                        {
                            arena[row, column] = "R";
                        }
                        else if (column == 5 || column == 7)//rooms connected with tunnels
                        {
                            arena[row, column] = "=";
                        }
                        else
                        {
                            arena[row, column] = " ";
                        }
                    }
                    else if (row == 3)//add more diagonal tunnels
                    {
                        if (column == 0 || column == 6 || column == 12)
                        {
                            arena[row, column] = "|";
                        }
                        else if (column == 1 || column == 9)
                        {
                            arena[row, column] = "\\";
                        }
                        else if (column == 3 || column == 11)
                        {
                            arena[row, column] = "/";
                        }
                        else
                        {
                            arena[row, column] = " ";
                        }
                    }
                    else if (row == 4)
                    {
                        if (column == 2 || column == 10)
                        {
                            arena[row, column] = "R";
                        }
                        else if (column == 0 || column == 6 || column == 12)
                        {
                            arena[row, column] = "|";
                        }
                        else
                        {
                            arena[row, column] = " ";
                        }
                    }
                    else if (row == 5)//add more tunnesl
                    {
                        if (column == 0 || column == 2 || column == 6 || column == 10 || column == 12)
                        {
                            arena[row, column] = "|";
                        }
                        else
                        {
                            arena[row, column] = " ";
                        }
                    }
                    else if (row == 6)
                    {
                        if (column == 2 || column == 6 || column == 10)
                        {
                            arena[row, column] = "R";
                        }
                        else if (column == 4 || column == 3 || column == 5 || column == 7 || column == 8 || column == 9)
                        {
                            arena[row, column] = "=";
                        }
                        else if (column == 0 || column == 12)
                        {
                            arena[row, column] = "|";
                        }
                        else
                        {
                            arena[row, column] = " ";
                        }
                    }
                    else if (row == 7)//add more tunnels
                    {
                        if (column == 0 || column == 2 || column == 10 || column == 12)
                        {
                            arena[row, column] = "|";
                        }
                        else
                        {
                            arena[row, column] = " ";
                        }
                    }
                    else if (row == 8)
                    {
                        if (column == 2 || column == 10)
                        {
                            arena[row, column] = "R";
                        } else if (column == 0 || column == 12)
                        {
                            arena[row, column] = "|";
                        }
                        else
                        {
                            arena[row, column] = " ";
                        }
                    }
                    else if (row == 9)// add even more tunnels
                    {
                        if (column == 0 || column == 12)
                        {
                            arena[row, column] = "|";
                        }
                        else if (column == 1 || column == 9)
                        {
                            arena[row, column] = "/";
                        }
                        else if (column == 3 || column == 11)
                        {
                            arena[row, column] = "\\";
                        }
                        else
                        {
                            arena[row, column] = " ";
                        }
                    }
                    else if (row == 10)
                    {
                        if (column == 0 || column == 4 || column == 8 || column == 12)
                        {
                            arena[row, column] = "R";
                        }
                        else if (column == 5 || column == 6 || column == 7)
                        {
                            arena[row, column] = "=";
                        }
                        else
                        {
                            arena[row, column] = " ";
                        }
                    }
                    else if (row == 11)//LAST TUNNELS
                    {
                        if (column == 1 || column == 9)
                        {
                            arena[row, column] = "\\";
                        }
                        else if (column == 3 || column == 11)
                        {
                            arena[row, column] = "/";
                        }
                        else
                        {
                            arena[row, column] = " ";
                        }
                    }
                    else if (row == 12)
                    {
                        if (column == 2 || column == 10)
                        {
                            arena[row, column] = "R";
                        }
                        else if (column == 5 || column == 3 || column == 4 || column == 6 || column == 7 || column == 8 || column == 9)
                        {
                            arena[row, column] = "=";
                        }
                        else
                        {
                            arena[row, column] = " ";
                        }
                    }
                    else
                    {
                        arena[row, column] = "_";
                    }
                }
            }
            return arena;
        }
        private static void PrintBoard(string[,] board)
        {
            int rowcount, columncount;
            for (rowcount = 0; rowcount < 13; rowcount++)
            {
                for (columncount = 0; columncount < 13; columncount++)
                {
                    Console.Write(board[rowcount, columncount]);
                }
                Console.WriteLine();
            }
        }
        private static Player InitPlayer()
        {
            //int playerx, playery, curammo, health;
            //playerx = 0;
            //playery = 0;
            Player myHunter = new Player();
            myHunter.MaxHealth = 100;
            myHunter.CurrentAmmo = 5;
            myHunter.CurrentHealth = myHunter.MaxHealth;

            myHunter.CurrentPlayerX = 0;
            myHunter.CurrentPlayerY = 2;

            return myHunter;

            //Set x and y to a legitimate room coordinate later maybe use a random gen init player class here
        }
        public class Player
        {
            public int CurrentHealth { get; set; }
            public int CurrentAmmo { get; set; }
            public int MaxAmmo { get; set; }
            public int MaxHealth { get; set; }
            public int CurrentPlayerX { get; set; }
            public int CurrentPlayerY { get; set; }
            public int UpdatePlayerX { get; set; }
            public int UpdatePlayerY { get; set; }
        }
    }
}
