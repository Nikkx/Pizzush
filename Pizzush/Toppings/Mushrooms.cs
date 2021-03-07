using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzush.Toppings
{
    /// <summary>
    /// Mushroom topping
    /// </summary>
    public class Mushrooms :ToppingDecorator
    {

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="pizza"></param>
        public Mushrooms(IPizza pizza) : base(pizza)
        {
        }

        /// <summary>
        /// Get cost
        /// </summary>
        /// <returns></returns>
        public override int GetCost()
        {
            return tempPizza.GetCost() + 5;
        }

        /// <summary>
        /// Get Description
        /// </summary>
        /// <returns></returns>
        public override string GetDescription()
        {
            return tempPizza.GetDescription() + ", Mushrooms";
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
