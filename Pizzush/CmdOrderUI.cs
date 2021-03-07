using System;
using System.Collections.Generic;
using System.Text;
using static Pizzush.Menu;
using Pizzush.Interfaces;

namespace Pizzush
{
    /// <summary>
    /// CMD order UI
    /// </summary>
    class CmdOrderUI : IOrderUI
    {
        /// <summary>
        /// draw menu and get order from user
        /// </summary>
        /// <param name="menu"></param>
        /// <returns></returns>
        public List<IFood> DrawMenu(Menu menu)
        {
            Console.WriteLine("Welcome to Pizzush!");
            Console.WriteLine("Please type the number of the dish you would like to order");
            Console.WriteLine("Please press enter after each name");
            Console.WriteLine("When finished, please type end");

            //Print menu
            for (int i = 0; i < menu.GetMenu().Count; i++) 
            {
                IFood item = menu.GetMenu()[i];
                Console.WriteLine(i + ". " + item.GetDescription() + " - " + item.GetCost()); 
            }

            List<IFood> orderedItems = new List<IFood>();

            // Get order from user
            while (true)
            {
                var userInput = Console.ReadLine();
                if (userInput == "end")
                {
                    break;
                }
                bool isNumeric = int.TryParse(userInput, out int n);
                if (!isNumeric)
                {
                    Console.WriteLine("please enter a number or 'end' only");
                    continue;
                }
                int id = int.Parse(userInput);
                if (id >= menu.GetMenu().Count)
                {
                    Console.WriteLine("Please enter an number of item from the mune or 'end'");
                    continue;
                }
                IFood orderedItem = menu.ConvertIdToIFood(id);
                
                if(orderedItem == null)
                {
                    Console.WriteLine("We don't serve this yet");
                }
                else
                {
                    orderedItems.Add(orderedItem);
                }
            }
            return orderedItems;
        }

        /// <summary>
        /// Draw payment info
        /// </summary>
        /// <param name="cost"></param>
        public void DrawPayment(int cost)
        {
            Console.WriteLine("Please pay " + cost + " " + IOrderUI.Currency);
        }
    }
}
