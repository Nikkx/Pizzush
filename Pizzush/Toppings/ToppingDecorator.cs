using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzush
{
    /// <summary>
    /// Abstract decorator - for toppings
    /// </summary>
    public abstract class ToppingDecorator : IPizza
    {
        protected IPizza tempPizza;

        /// <summary>
        /// CTOR
        /// </summary>
        /// <param name="pizza"></param>
        public ToppingDecorator(IPizza pizza)
        {
            tempPizza = pizza;
        }

        /// <summary>
        /// Get Cost
        /// </summary>
        /// <returns></returns>
        public abstract int GetCost();

        /// <summary>
        /// Get Description
        /// </summary>
        /// <returns></returns>
        public abstract string GetDescription();

        /// <summary>
        /// Get preparetion time
        /// </summary>
        /// <returns></returns>
        public abstract int GetPrepareTime();
    }
}
