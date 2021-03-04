using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzush
{
    class Order
    {
        int orderNum;
        List<List<IFood>> foodItems;

        public Order(int orderNum, List<IFood> orderedItems)
        {
            //todo create order
            foreach (List<IFood> list in orderedItems)
            {
                list.Reverse();
                // IPizza BasicPizza = new Mozzarella(new TomatoSauce(new PlainPizza()));
                IFood BasicFood;
                foreach(IFood item in list)
                {

                }
            }
            this.orderNum = orderNum;
           // this.foodItems = foods;
        }

        /// <summary>
        /// Prepare the order
        /// </summary>
        /// <returns>time takes to prepare</returns>
        public int Prepare()
        {
            int time = 0;
            for (int i = 0; i < foodItems.Count; i++)
            {
              //todo  time += foodItems[i].GetPrepareTime();
            }
            return time;
        }
    }
}
