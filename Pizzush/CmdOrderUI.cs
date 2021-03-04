using System;
using System.Collections.Generic;
using System.Text;
using static Pizzush.Menu;

namespace Pizzush
{
    class CmdOrderUI : IOrderUI
    {
        //draw Pizza menu
        public List<int> DrawMenu(Menu menu)
        {
            Console.WriteLine("Welcome to Pizzush!");
            Console.WriteLine("Please type the number of the dish you would like to order, shown in []");
            Console.WriteLine("Please press enter after each number");
            Console.WriteLine("When finished, please type end");

            //Print menu
            //foreach (PizzaMenuEnum item in menu.GetMenu()) //TODO
            //{
            //    Console.WriteLine($"[{(int)item}] {item}");
            //}

            //Console.WriteLine("Choose toppings, type \"end\" when finished.");
            //foreach (PizzaMenuEnum item in menu.GetMenu())
            //{
            //    //not crusts -> toppings.
            //    if (!item.ToString().Contains("Crust"))
            //    {
            //        Console.Write($"[{(int)item}] {item}\t");
            //    }
            //    Console.WriteLine("\n");
            //}

            //for (int i = 0; i < menu.GetMenu().Length; i++)
            //{
            //    IFood item = menu.GetMenu()[i];
            //    Console.WriteLine(item.GetID() + ". " + item.GetName() + " " + item.GetCost());
            //    Console.WriteLine(item.GetDescription());
            //}

            //Get order from user
            List<int> orderedItems = new List<int>();

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
                //if (!isValidID(menu, id)) //TODO validate user input
                //{
                //    Console.WriteLine("Please enter an number of item from the mune or 'end'");
                //    continue;
                //}
                orderedItems.Add(id);
            }
            return orderedItems;
        }

        public void DrawPayment(int cost)
        {
            Console.WriteLine("Please pay " + cost + " " + IOrderUI.Currency);
        }

        //bool IsValidID(Menu menu, int id)
        //{
        //    for (int i = 0; i < menu.GetMenu().Count; i++)
        //    {
        //        IFood item = menu.GetMenu()[i];
        //        if (item.GetID() == id)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}
    }
}
