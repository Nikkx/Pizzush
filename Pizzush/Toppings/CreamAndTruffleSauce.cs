using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzush.Toppings
{
    /// <summary>
    /// Cream And Truffle Sauce topping
    /// </summary>
    public class CreamAndTruffleSauce :ToppingDecorator
    {
        /// <summary>
        /// CTOR
        /// </summary>
        /// <param name="pizza"></param>
        public CreamAndTruffleSauce(IPizza pizza) : base(pizza)
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
        /// Get Description
        /// </summary>
        /// <returns></returns>
        public override string GetDescription()
        {
            return tempPizza.GetDescription() + ", Cream And Truffle Sauce";
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
