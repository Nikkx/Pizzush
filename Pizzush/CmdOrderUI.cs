using System;
using System.Collections.Generic;
using System.Text;
using static Pizzush.Menu;
using Pizzush.Interfaces;

namespace Pizzush
{
    class CmdOrderUI : IOrderUI
    {
        //draw menu and get order from user
        public List<MenuItem> DrawMenu(Menu menu)
        {
            Console.WriteLine("Welcome to Pizzush!");
            Console.WriteLine("Please type the name of the dish you would like to order");
            Console.WriteLine("Please press enter after each name");
            Console.WriteLine("When finished, please type end");

            //Print menu
            foreach (MenuItem item in menu.GetMenu()) 
            {
                Console.WriteLine(item.GetName() + " - " + item.GetPrice()); 
            }

            List<MenuItem> orderedItems = new List<MenuItem>();

            // Get order from user
            while (true)
            {
                var userInput = Console.ReadLine();
                if (userInput == "end")
                {
                    break;
                }
                MenuItem orderedItem = menu.ConvertNameToIFood(userInput);
                
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

        // Draw payment info 
        public void DrawPayment(int cost)
        {
            Console.WriteLine("Please pay " + cost + " " + IOrderUI.Currency);
        }
    }
}
