using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using Pizzush.Interfaces;

namespace Pizzush
{
    class OrderInfoUI : IOrderInfoUI
    {
        List<int> inPrep;
        List<int> done;

        public OrderInfoUI()
        {
            inPrep = new List<int>();
            done = new List<int>();
        }
        public void DrawInfo()
        {
            Console.WriteLine("In Prepare:");
            PrintList(inPrep);
      
            Console.WriteLine("Done: ");
            PrintList(done);
        }

        public void UpdateDoneOrder(int orderId)
        {
            inPrep.Remove(orderId);
            done.Add(orderId);
            DrawInfo();
        }

        public void UpdateNewOrder(int orderId)
        {
            inPrep.Add(orderId);
            DrawInfo();
        }

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
