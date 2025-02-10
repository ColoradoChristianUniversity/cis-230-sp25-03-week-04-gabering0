using Client.Library;
using System;

namespace Client
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var items = await Api.GetStringArrayAsync();
            int selectedIndex = 0;

            while (true)
            {
                Console.Clear();

                for (int i = 0; i < items.Length; i++)
                {
                    string itemText = $"{i + 1}. {items[i]}"; 

                    if (i == selectedIndex)
                    {
                        Screen.Print(itemText, 0, i, ConsoleColor.Black, ConsoleColor.White); 
                    }
                    else
                    {
                        Screen.Print(itemText, 0, i); 
                    }
                }

                var key = Screen.Listen(ConsoleKey.UpArrow, ConsoleKey.DownArrow, ConsoleKey.Enter, ConsoleKey.Escape);

                if (key == ConsoleKey.UpArrow)
                {
                    selectedIndex = (selectedIndex > 0) ? selectedIndex - 1 : items.Length - 1;
                }
                else if (key == ConsoleKey.DownArrow)
                {
                    selectedIndex = (selectedIndex < items.Length - 1) ? selectedIndex + 1 : 0;
                }
                else if (key == ConsoleKey.Enter) 
                {
                    string selectedItem = items[selectedIndex];
                    Screen.SurroundWithBorder(new System.Drawing.Point(0, selectedIndex), new System.Drawing.Size(selectedItem.Length + 2, 3));

                    int messageY = Math.Min(items.Length + 1, Console.WindowHeight - 1);

                    Screen.Print($"You selected: {selectedItem}", 0, messageY, ConsoleColor.White, ConsoleColor.White); // Print the selection message
                    Console.ReadKey(); 
                }
                else if (key == ConsoleKey.Escape)
                {
                    break;
                }

                // Prompt to continue after each action
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }

            // Exit message after breaking the loop
            Console.WriteLine("\nExiting the program...");
        }
    }
}