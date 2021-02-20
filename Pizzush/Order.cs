using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzush
{
    class Order
    {
        int orderNum;
        List<IFood> foodItems;

        public Order(int orderNem, List<IFood> foods)
        {
            this.orderNum = orderNem;
            this.foodItems = foods;
        }

        public int Prepare()
        {
            int time = 0;
            for (int i = 0; i < this.foodItems.Count; i++)
            {
                time += this.foodItems[i].GetPrepareTime();
            }
            return time;
        }
    }
}
