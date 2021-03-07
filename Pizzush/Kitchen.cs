using System;
using System.Collections.Generic;
using System.Text;
using Pizzush.Interfaces;
using System.Threading;

namespace Pizzush
{
    /// <summary>
    /// Kitchen class
    /// </summary>
    public class Kitchen
    {
        List<IOrderInfoUI> UIs;
        Queue<Order> orders;

        /// <summary>
        /// CTOR
        /// </summary>
        public Kitchen()
        {
            UIs = new List<IOrderInfoUI>();
            orders = new Queue<Order>();

            UIs.Add(new OrderInfoUI());
            Thread t = new Thread(new ThreadStart(Prepare));
            t.Start();
        }

        public void NewOrder(Order order)
        {
            orders.Enqueue(order);
            NotifyNewOrder(order);
        }

        public void NotifyNewOrder(Order order)
        {
            foreach(IOrderInfoUI ui in UIs)
            {
                ui.UpdateNewOrder(order.GetOrderNumber());
            }
        }

        public void NotifyDoneOrder(Order order)
        {
            foreach (IOrderInfoUI ui in UIs)
            {
                ui.UpdateDoneOrder(order.GetOrderNumber());
            }
        }

        public void Prepare()
        {
            while (true)
            {
                if (orders.Count > 0)
                {
                    //Console.WriteLine("Kitchen got a new order");
                    Order order = orders.Dequeue();
                    int prepTime = order.Prepare();
                    Thread.Sleep(prepTime * 100);
                    NotifyDoneOrder(order);
                    //Console.WriteLine("order done");
                }
            }
        }



    }
}
