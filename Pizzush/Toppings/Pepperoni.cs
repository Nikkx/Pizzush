using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzush.Toppings
{
    public class Pepperoni :ToppingDecorator
    {
        public Pepperoni(IPizza pizza) : base(pizza)
        {
            Console.WriteLine("Adding Pepperoni...");
        }
        public override int GetCost()
        {
            return tempPizza.GetCost() + 7;
        }

        public override string GetDescription()
        {
            return tempPizza.GetDescription() + ", Pepperoni";
        }

        public override int GetPrepareTime()
        {
            return tempPizza.GetPrepareTime() + 1;
        }
    }
}
