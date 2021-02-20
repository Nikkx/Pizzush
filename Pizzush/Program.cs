using System;
using System.Collections.Generic;

namespace Pizzush
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu m = new Menu();

            OrderTaker take = new OrderTaker();

            Order o =  take.NewOrder();

            Order o1 = take.NewOrder();

            Console.WriteLine("dfdf");







        }
    }
}
