using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzush
{
    class OrderTaker
    {
        Menu menu;
        int counter;
        IOrderUI ui;

        public OrderTaker()
        {
            menu = new Menu();
            counter = 0;
            ui = new CmdOrderUI();
        }

        public Order NewOrder()
        {
            List<int> orderedItemsIds = this.ui.DrawMenu(menu); //list of IFood?
            //list of lists that represents the order - each inner list is a pizza with toppings
            List<IFood> orderedItems = IdToFoodItem(orderedItemsIds);
            Order order = new Order(counter, orderedItems);
            counter++;
            int cost = CalculateCost(orderedItems);
            ui.DrawPayment(cost);

            return order;

        }

        private List<IFood> IdToFoodItem(List<int> ids)
        {
            List<IFood> foodItems = new List<IFood>();
            for (int i = 0; i < ids.Count; i++)
            {
                //for (int j = 0; j < this.menu.GetMenu().Count; j++)
                //{
                //    if (ids[i] == this.menu.GetMenu()[j].GetID())
                //    {
                //        foodItems.Add(menu.GetMenu()[j]);
                //    }
                //}
            }
            return foodItems;
        }

        private int CalculateCost(List<IFood> orderedItems)
        {
            int cost = 0;
            for (int i = 0; i < orderedItems.Count; i++)
            {
                cost += orderedItems[i].GetCost();
            }
            return cost;
        }

    }
}
