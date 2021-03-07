using System;
using System.Collections.Generic;
using System.Text;
using Pizzush.Interfaces;

namespace Pizzush
{
    interface IOrderUI
    {
        const string Currency = "NIS";

        // Will draw the menu, and accept the users order.
        public List<MenuItem> DrawMenu(Menu menu);

        // Will draw the amount to pay
        public void DrawPayment(int cost);
    }
}
