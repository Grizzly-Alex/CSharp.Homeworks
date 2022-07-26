using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace HW._11.DatabaseOfMotorcycles.Menu
{
    internal class Menu
    {
        private int selectedIndex = 0;

        private void GraphicSelection(List<Object> items)
        {
            //creating base menu
            ForegroundColor = ConsoleColor.Green;

            for (int i = 0; i < items.Count; i++)
            {
                string currentItem = items[i].ToString();
                char prefix;

                if (i.Equals(selectedIndex))
                {
                    prefix = '►';
                    ForegroundColor = ConsoleColor.Yellow;
                }
                else
                {
                    prefix = ' ';
                    ForegroundColor = ConsoleColor.Green;
                }
                WriteLine("  " + prefix + " " + currentItem);
            }

            ForegroundColor = ConsoleColor.Green;
            ResetColor();
        }

        public int ShowGraphicSelection(List<Object> items, string title)
        {

            ConsoleKey keyPressed;

            do
            {
                Clear();
                WriteLine($"   {title}");              
                GraphicSelection(items);

                ConsoleKeyInfo keyInfo = ReadKey(true);
                keyPressed = keyInfo.Key;

                //update logic for selection arrow 
                if (keyPressed.Equals(ConsoleKey.UpArrow))
                {
                    selectedIndex--;

                    if (selectedIndex.Equals(-1))
                    {
                        selectedIndex = items.Count - 1;
                    }
                }
                else if (keyPressed.Equals(ConsoleKey.DownArrow))
                {
                    selectedIndex++;

                    if (selectedIndex.Equals(items.Count))
                    {
                        selectedIndex = 0;
                    }
                }
            }
            while (!keyPressed.Equals(ConsoleKey.Enter));

            return selectedIndex;
        }

        public void ResetSelectIndex() => selectedIndex = 0;
    }
}