using Client.Library;
using System;

namespace Client
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var items = await Api.GetStringArrayAsync(); // Fetch the string array from the API
            int selectedIndex = 0;

            while (true)
            {
                // Clear the screen before each display
                Console.Clear();

                // Display the menu as a numbered list
                for (int i = 0; i < items.Length; i++)
                {
                    var itemText = $"{i + 1}. {items[i]}";
                    if (i == selectedIndex)
                    {
                        // Highlight the selected item
                        Screen.Print(itemText, 0, i, ConsoleColor.Black, ConsoleColor.White);
                    }
                    else
                    {
                        // Print non-selected items normally
                        Screen.Print(itemText, 0, i);
                    }
                }

                // Listen for key presses (Up, Down, Enter)
                var key = Screen.Listen(ConsoleKey.UpArrow, ConsoleKey.DownArrow, ConsoleKey.Enter);

                if (key == ConsoleKey.UpArrow)
                {
                    // Move the selection up
                    selectedIndex = (selectedIndex > 0) ? selectedIndex - 1 : items.Length - 1;
                }
                else if (key == ConsoleKey.DownArrow)
                {
                    // Move the selection down
                    selectedIndex = (selectedIndex < items.Length - 1) ? selectedIndex + 1 : 0;
                }
                else if (key == ConsoleKey.Enter)
                {
                    // When Enter is pressed, display the selected item with a border
                    Screen.SurroundWithBorder(new System.Drawing.Point(0, selectedIndex), new System.Drawing.Size(items[selectedIndex].Length + 2, 3));
                    Screen.Print(items[selectedIndex], 1, selectedIndex + 1);
                    Console.ReadKey();  // Wait for any key to continue
                }

                // Restart the loop until user exits manually
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
        }
    }
}