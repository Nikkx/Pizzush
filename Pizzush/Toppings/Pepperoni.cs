using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzush.Toppings
{
    public class Pepperoni :ToppingDecorator
    {
        /// <summary>
        /// Pepperoni topping
        /// </summary>
        /// <param name="pizza"></param>
        public Pepperoni(IPizza pizza) : base(pizza)
        {
        }

        /// <summary>
        /// Get Cost
        /// </summary>
        /// <returns></returns>
        public override int GetCost()
        {
            return tempPizza.GetCost() + 7;
        }

        /// <summary>
        /// Get Item Description
        /// </summary>
        /// <returns></returns>
        public override string GetDescription()
        {
            return tempPizza.GetDescription() + ", Pepperoni";
        }

        /// <summary>
        /// Get preparetion time
        /// </summary>
        /// <returns></returns>
        public override int GetPrepareTime()
        {
            return tempPizza.GetPrepareTime() + 1;
        }
    }
}
