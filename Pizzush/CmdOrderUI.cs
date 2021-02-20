using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzush
{
    class CmdOrderUI : IOrderUI
    {
        public List<int> DrawMenu(Menu menu)
        {
            Console.WriteLine("Welcome to Pizzush!");
            Console.WriteLine("Please type the number of the dish you would likr to order");
            Console.WriteLine("Please press enter after each number");
            Console.WriteLine("When finished, please type end");

            for (int i = 0; i < menu.getMenu().Count; i++ )
            {
                IFood item = menu.getMenu()[i];
                Console.WriteLine(item.GetID() + ". " + item.GetName() + " " + item.GetCost());
                Console.WriteLine(item.GetDescription());
            }

            List<int> orderedItems = new List<int>();

            while (true)
            {
                var userInput = Console.ReadLine();
                if (userInput == "end")
                {
                    break;
                }
                bool isNumeric = int.TryParse(userInput, out int n);
                if(!isNumeric)
                {
                    Console.WriteLine("please enter a number or 'end' only");
                    continue;
                }
                int id = int.Parse(userInput);
                if(!isValidID(menu, id))
                {
                    Console.WriteLine("Please enter an number of item from the mune or 'end'");
                    continue;
                }
                orderedItems.Add(id);
            }
            return orderedItems;
        }

        public void DrawPayment(int cost)
        {
            Console.WriteLine("Please pay " + cost + " " + IOrderUI.Currency);
        }

        bool isValidID(Menu menu, int id)
        {
            for (int i = 0; i < menu.getMenu().Count; i++)
            {
                IFood item = menu.getMenu()[i];
                if (item.GetID() == id)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
