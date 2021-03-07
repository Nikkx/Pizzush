using System;
using System.Collections.Generic;
using System.Text;
using Pizzush.Interfaces;

namespace Pizzush
{
    /// <summary>
    /// Order Ui Interface
    /// </summary>
    interface IOrderUI
    {
        const string Currency = "NIS";

        /// <summary>
        /// Will draw the menu, and accept the users order.
        /// </summary>
        /// <param name="menu"></param>
        /// <returns></returns>
        public List<IFood> DrawMenu(Menu menu);

        /// <summary>
        /// Will draw the amount to pay
        /// </summary>
        /// <param name="cost"></param>
        public void DrawPayment(int cost);
    }
}
