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
        /// <summary>
        /// info uis
        /// </summary>
        List<IOrderInfoUI> UIs;

        /// <summary>
        /// orders
        /// </summary>
        Queue<Order> Orders;

        /// <summary>
        /// CTOR
        /// </summary>
        public Kitchen()
        {
            UIs = new List<IOrderInfoUI>();
            Orders = new Queue<Order>();

            UIs.Add(new OrderInfoUI());
            Thread t = new Thread(new ThreadStart(Prepare));
            t.Start();
        }

        /// <summary>
        /// add new order
        /// </summary>
        /// <param name="order"></param>
        public void NewOrder(Order order)
        {
            Orders.Enqueue(order);
            NotifyNewOrder(order);
        }

        /// <summary>
        /// Notify new order
        /// </summary>
        /// <param name="order"></param>
        public void NotifyNewOrder(Order order)
        {
            foreach(IOrderInfoUI ui in UIs)
            {
                ui.UpdateNewOrder(order.GetOrderNumber());
            }
        }

        /// <summary>
        /// Notify order done
        /// </summary>
        /// <param name="order"></param>
        public void NotifyDoneOrder(Order order)
        {
            foreach (IOrderInfoUI ui in UIs)
            {
                ui.UpdateDoneOrder(order.GetOrderNumber());
            }
        }

        /// <summary>
        /// Prepare the item
        /// </summary>
        public void Prepare()
        {
            while (true)
            {
                if (Orders.Count > 0)
                {
                    //Console.WriteLine("Kitchen got a new order");
                    Order order = Orders.Dequeue();
                    int prepTime = order.Prepare();
                    Thread.Sleep(prepTime * 100);
                    NotifyDoneOrder(order);
                    //Console.WriteLine("order done");
                }
            }
        }



    }
}
