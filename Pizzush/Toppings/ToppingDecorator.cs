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

        public ToppingDecorator(IPizza pizza)
        {
            tempPizza = pizza;
        }

        public abstract int GetCost();

        public abstract string GetDescription();

        public abstract int GetPrepareTime();

       // public abstract int GetID();


        //public int GetCost()
        //{
        //    return tempPizza.GetCost();
        //}

        //public string GetDescription()
        //{
        //    return tempPizza.GetDescription();
        //}

        //public int GetPrepareTime()
        //{
        //    return tempPizza.GetPrepareTime();
        //}
    }
}
