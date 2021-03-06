using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzush.Toppings
{
    public class CreamAndTruffleSauce :ToppingDecorator
    {
        public CreamAndTruffleSauce(IPizza pizza) : base(pizza)
        {
            Console.WriteLine("Adding Cream And Truffle Sauce...");
        }
        public override int GetCost()
        {
            return tempPizza.GetCost() + 7;
        }

        public override string GetDescription()
        {
            return tempPizza.GetDescription() + ", Cream And Truffle Sauce";
        }

        public override int GetPrepareTime()
        {
            return tempPizza.GetPrepareTime() + 1;
        }
    }
}
