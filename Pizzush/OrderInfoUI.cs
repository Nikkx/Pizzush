using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using Pizzush.Interfaces;

namespace Pizzush
{ 
    /// <summary>
    /// Order Info UI CMD
    /// </summary>
    class OrderInfoUI : IOrderInfoUI
    {
        /// <summary>
        /// items in preparation
        /// </summary>
        List<int> InPrep;

        /// <summary>
        /// items that are done
        /// </summary>
        List<int> Done;

        public OrderInfoUI()
        {
            InPrep = new List<int>();
            Done = new List<int>();
        }

        /// <summary>
        /// Draw info
        /// </summary>
        public void DrawInfo()
        {
            Console.WriteLine("Preparing: ");
            PrintList(InPrep);
      
            Console.WriteLine("Done: ");
            PrintList(Done);
        }

        /// <summary>
        /// Update Done Order
        /// </summary>
        /// <param name="orderId"></param>
        public void UpdateDoneOrder(int orderId)
        {
            InPrep.Remove(orderId);
            Done.Add(orderId);
            DrawInfo();
        }

        /// <summary>
        /// Update New Order
        /// </summary>
        /// <param name="orderId"></param>
        public void UpdateNewOrder(int orderId)
        {
            InPrep.Add(orderId);
            DrawInfo();
        }

        /// <summary>
        /// Print list
        /// </summary>
        /// <param name="list"></param>
        void PrintList(List<int> list)
        {
            foreach (int item in list)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
        }
    }
}
