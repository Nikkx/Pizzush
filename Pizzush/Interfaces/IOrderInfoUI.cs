using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzush.Interfaces
{
    /// <summary>
    /// Order Info UI interface
    /// </summary>
    public interface IOrderInfoUI
    {
        /// <summary>
        /// Draw UI
        /// </summary>
        public void DrawInfo();

        /// <summary>
        /// Update the UI that a new order was accepted by the kitchen
        /// </summary>
        /// <param name="orderId"></param>
        public void UpdateNewOrder(int orderId);

        /// <summary>
        /// Update the UI that an order is ready
        /// </summary>
        /// <param name="orderId"></param>
        public void UpdateDoneOrder(int orderId);
    }
}
