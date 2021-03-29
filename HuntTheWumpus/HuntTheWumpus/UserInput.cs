using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HuntTheWumpus
{
    public static class UserInput
    {
       public static string MoveOrShoot()
        {
            Console.Write("SHOOT OR MOVE (S-M) ? ");
            int xPos = Console.CursorLeft;
            while (true)
            {
                
                string input = Console.ReadLine();
                try
                {
                    if (input.ToUpper() == "S" || input.ToUpper() == "M")
                    {
                        return input.ToUpper();
                    }
                    else
                    {
                        throw new ArgumentException(input);
                    }
                }
                catch (ArgumentException)
                {
                    Console.WriteLine($"Error.  {input} is not a valid selection.  Press any key to continue");
                    Console.ReadKey();
                    ClearInput(input,xPos);
                }
            }
        }
        public static int GetInteger(int min, int max)
        {
            while (true)
            {
                int xPos = Console.CursorLeft;
                string input = Console.ReadLine();
                try
                {
                    if (int.TryParse(input, out int number))
                    {
                        if (number >= min && number <= max)
                        {
                            return number;
                        }
                        else
                        {
                            throw new ArgumentOutOfRangeException(input);
                        }
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException(input);
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine($"Error: {input} is not a valid selection.  Press any key to continue.");
                    Console.ReadKey();
                    ClearInput(input,xPos);
                }
            }
        }
        public static int GetTarget(int [] rooms)
        {
            while (true)
            {
                int xPos = Console.CursorLeft;
                string input = Console.ReadLine();
                try
                {
                    if (int.TryParse(input, out int number))
                    {
                        if (rooms.Contains(number))
                        {
                            return number;
                        }
                        else
                        {
                            throw new ArgumentOutOfRangeException(input);
                        }
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine($"\tError: {input} is not a valid selection.  Press any key to continue.");
                    Console.ReadKey();
                    ClearInput(input, xPos);
                }
            }
        }
        public static void ClearInput(string input, int cursorPos)
        {
            int y = Console.CursorTop -1;
            Console.SetCursorPosition(0, y);
            Console.Write(new string(' ', Console.BufferWidth));

            Console.SetCursorPosition(cursorPos, y-1);
            Console.Write(new string(' ', Console.BufferWidth));
            Console.SetCursorPosition(cursorPos, y-1);
        }
    }
}
