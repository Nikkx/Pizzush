using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzush
{
    /// <summary>
    /// Mozzarella topping
    /// </summary>
    public class Mozzarella : ToppingDecorator
    {
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="pizza"></param>
        public Mozzarella(IPizza pizza) : base(pizza)
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
            return tempPizza.GetDescription() + ", Mozzarella";
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
