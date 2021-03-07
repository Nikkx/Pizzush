using System;
using System.Collections.Generic;
using System.Text;
using Pizzush.Interfaces;

namespace Pizzush
{
    /// <summary>
    /// Order class
    /// </summary>
    public class Order
    {
        // to identify the order 
        int orderNum;
        List<IFood> foodItems;

        public Order(int orderNum, List<IFood> orderedItems)
        {
            this.foodItems = orderedItems;
            this.orderNum = orderNum;
        }

        /// <summary>
        /// calculate the approximate time it will take to prapare the order
        /// </summary>
        /// <returns></returns>
        public int Prepare()
        {
            int time = 0;
            foreach (IFood item in this.foodItems)
            {
              time += item.GetPrepareTime();
            }
            return time;
        }

        /// <summary>
        /// Get Order Number
        /// </summary>
        /// <returns></returns>
        public int GetOrderNumber()
        {
            return orderNum;
        }

        /// <summary>
        /// Get Food Items list
        /// </summary>
        /// <returns></returns>
        public List<IFood> GetFoodItems()
        {
            return foodItems;
        }

    }
}
