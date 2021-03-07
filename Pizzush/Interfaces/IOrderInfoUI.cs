using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzush.Interfaces
{
    public interface IOrderInfoUI
    {
        public void DrawInfo();

        // Update the UI that a new order was accepted by the kitchen
        public void UpdateNewOrder(int orderId);

        // Update the UI that an order is ready
        public void UpdateDoneOrder(int orderId);
    }
}
