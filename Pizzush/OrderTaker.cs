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
            this.menu = new Menu();
            this.counter = 0;
            this.ui = new CmdOrderUI();
        }

        public Order NewOrder()
        {
            List<int> orderedItemsIds = this.ui.DrawMenu(menu);
            List<IFood> orderedItems = idToFoodItem(orderedItemsIds);
            Order order = new Order(this.counter, orderedItems);
            this.counter++;
            int cost = CalculateCost(orderedItems);
            ui.DrawPayment(cost);

            return order;

        }

        private List<IFood> idToFoodItem(List<int> ids)
        {
            List<IFood> foodItems = new List<IFood>();
            for (int i = 0; i < ids.Count; i++)
            {
                for (int j = 0; j < this.menu.getMenu().Count; j++)
                {
                    if (ids[i] == this.menu.getMenu()[j].GetID())
                    {
                        foodItems.Add(menu.getMenu()[j]);
                    }
                }
            }
            return foodItems;
        }

        private int CalculateCost(List<IFood> orderedItems)
        {
            int cost = 0;
            for(int i = 0; i < orderedItems.Count; i++)
            {
                cost += orderedItems[i].GetCost();
            }
            return cost;
        }

    }
}
