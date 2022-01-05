using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUITools
{
    public class SecondMenu:Menu
    {
        public override int OpenMenu()
        {
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Gray;
            int choiceElement = 0;
            ConsoleKeyInfo key;
            do
            {
                Console.SetCursorPosition(0, 0);

                for (int i = 0; i < elements.Length; i++)
                {
                    if (i == choiceElement)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                    }
                    Console.WriteLine(elements[i].PadRight(25).ToUpper());

                }

                key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.UpArrow && choiceElement > 0)
                {
                    choiceElement--;
                }
                else if (key.Key == ConsoleKey.DownArrow && choiceElement < elements.Length - 1)
                {
                    choiceElement++;
                }
                if (key.Key == ConsoleKey.Escape)
                {
                    choiceElement = -1;
                }
            } while (key.Key != ConsoleKey.Enter && key.Key != ConsoleKey.Escape);

            Console.CursorVisible = true;
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
            return choiceElement;
        }
    }
}
