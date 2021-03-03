using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzush
{
    interface IOrderUI
    {
        const string Currency = "NIS";
       // public List<IFood> DrawMenu(Menu menu);//why returns int and not IFood?
        public List<int> DrawMenu(Menu menu);
        public void DrawPayment(int cost);
    }
}
