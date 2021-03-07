using System;
using System.Collections.Generic;
using System.Text;
using Pizzush.Interfaces;

namespace Pizzush
{
    class OrderTaker
    {
        Menu menu;
        int counter;
        IOrderUI ui;

        public OrderTaker()
        {
            menu = new Menu(); // To print to the customer
            counter = 0; // To identify each order
            ui = new CmdOrderUI(); // To support different kinds of UI
        }

        public Order NewOrder()
        {
            // Print menu to the user and get his order
            List<MenuItem> orderedItems = ui.DrawMenu(menu); 
            // create a new order object
            Order order = new Order(counter, orderedItems);
            // Count the orders of the day to identify them
            counter++;
            // Calculate the cost the present to the user
            int cost = CalculateCost(orderedItems);
            ui.DrawPayment(cost);

            return order;
        }

        private int CalculateCost(List<MenuItem> orderedItems)
        {
            int cost = 0;
            foreach (MenuItem item in orderedItems)
            {
                cost += item.GetPrice();
            }
            return cost;
        }

    }
}
