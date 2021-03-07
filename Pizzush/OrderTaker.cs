using System;
using System.Collections.Generic;
using System.Text;
using Pizzush.Interfaces;

namespace Pizzush
{
    /// <summary>
    /// Order Taker class
    /// </summary>
    class OrderTaker
    {
        Menu menu;
        int counter = 0;
        IOrderUI ui;
        Kitchen kitchen;

        /// <summary>
        /// CTOR
        /// </summary>
        public OrderTaker()
        {
            menu = new Menu(); // To print to the customer
            
            ui = new CmdOrderUI(); // To support different kinds of UI
            kitchen = new Kitchen(); // To Papare the food
        }

        /// <summary>
        /// Create new order
        /// </summary>
        public void NewOrder()
        {
            // Print menu to the user and get his order
            List<IFood> orderedItems = ui.DrawMenu(menu); 
            // create a new order object
            Order order = new Order(counter, orderedItems);
            // Count the orders of the day to identify them
            counter++;
            // Sent the order to the kitchen
            kitchen.NewOrder(order);
            // Calculate the cost the present to the user
            int cost = CalculateCost(orderedItems);
            ui.DrawPayment(cost);
        }

        /// <summary>
        /// Calsulate order cost
        /// </summary>
        /// <param name="orderedItems"></param>
        /// <returns></returns>
        private int CalculateCost(List<IFood> orderedItems)
        {
            int cost = 0;
            foreach (IFood item in orderedItems)
            {
                cost += item.GetCost();
            }
            return cost;
        }
    }
}
