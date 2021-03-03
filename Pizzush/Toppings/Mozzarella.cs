using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzush
{
    public class Mozzarella : ToppingDecorator
    {
        public Mozzarella(IPizza pizza) : base(pizza) {
            Console.WriteLine("Adding Mozzarella...");
        }
          public override int GetCost()
        {
            return tempPizza.GetCost() + 5;
        }

         public override string GetDescription()
        {
            return tempPizza.GetDescription() + ", Mozzarella";
        }

          public override int GetPrepareTime()
        {
            return tempPizza.GetPrepareTime() +1;
        }
    }
}
