using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUITools
{
    public class Menu //MUSIMY DAĆ KLASĘ PUBLICZNĄ, ABY DOŁĄCZYĆ DO PROJEKTU
    {
        protected string[] elements = new string[0];

        public void Configure(string[] elementsMenu)
        {
            if (elementsMenu != null)
            {
                elements = elementsMenu;
            }
        }

        public virtual int OpenMenu()
        {
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Red;
            int choiceElement = 0;
            ConsoleKeyInfo key;
            do
            {
                Console.SetCursorPosition(0, 0);

                for (int i = 0; i < elements.Length; i++)
                {
                    if (i == choiceElement)
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Cyan;
                    }
                    Console.SetCursorPosition((Console.WindowWidth - elements[i].Length) / 2, Console.CursorTop);
                    Console.WriteLine(elements[i].ToUpper());
                    Console.WriteLine();
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
