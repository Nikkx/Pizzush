using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzush
{
    class TomatoSauce : ToppingDecorator
    {
        public TomatoSauce(IPizza pizza) : base(pizza)
        {
            Console.WriteLine("Adding TomatoSauce...");
        }
         public override int GetCost()
        {
            return tempPizza.GetCost() + 5;
        }

         public override string GetDescription()
        {
            return tempPizza.GetDescription() + ", Tomato Sauce";
        }

         public override int GetPrepareTime()
        {
            return tempPizza.GetPrepareTime() + 1;
        }
    }
}
