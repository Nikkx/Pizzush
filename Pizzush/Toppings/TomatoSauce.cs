using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzush
{
    /// <summary>
    /// Tomato sauce topping
    /// </summary>
    class TomatoSauce : ToppingDecorator
    {
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="pizza"></param>
        public TomatoSauce(IPizza pizza) : base(pizza)
        {
        }

        /// <summary>
        /// Get Cost
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
            return tempPizza.GetDescription() + ", Tomato Sauce";
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
