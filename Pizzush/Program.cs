using System;
using System.Collections.Generic;
using System.Reflection;

namespace Pizzush
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderTaker main = new OrderTaker();
            while (true)
            {
                main.NewOrder();
            }
        }
    }
}
