using System;
using System.Collections.Generic;
using System.Reflection;

namespace Pizzush
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                OrderTaker main = new OrderTaker();
                main.NewOrder();
            }
        }
    }
}
