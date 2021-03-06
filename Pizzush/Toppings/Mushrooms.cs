using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzush.Toppings
{
    public class Mushrooms :ToppingDecorator
    {
        public Mushrooms(IPizza pizza) : base(pizza)
        {
            Console.WriteLine("Adding Mushrooms...");
        }
        public override int GetCost()
        {
            return tempPizza.GetCost() + 5;
        }

        public override string GetDescription()
        {
            return tempPizza.GetDescription() + ", Mushrooms";
        }

        public override int GetPrepareTime()
        {
            return tempPizza.GetPrepareTime() + 1;
        }
    }
}
