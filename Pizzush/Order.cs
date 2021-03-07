using System;
using System.Collections.Generic;
using System.Text;
using Pizzush.Interfaces;

namespace Pizzush
{
    public class Order
    {
        int orderNum; // to identify the order 
        List<MenuItem> foodItems;

        public Order(int orderNum, List<MenuItem> orderedItems)
        {
            this.foodItems = orderedItems;
            this.orderNum = orderNum;
        }

       // calculate the approximate time it will take to prapare the order
        public int Prepare()
        {
            int time = 0;
            foreach (MenuItem item in this.foodItems)
            {
              time += item.GetPrepTime();
            }
            return time;
        }

        public int GetOrderNumber()
        {
            return this.orderNum;
        }

        public List<MenuItem> GetFoodItems()
        {
            return this.foodItems;
        }

    }
}
