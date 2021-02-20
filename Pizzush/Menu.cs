using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzush
{
    class Menu
    {
        List<IFood> menu = new List<IFood>();

        public Menu()
        {
            IFood margarita = new IFood(1, "margarita", "simple pizza margarita", 50, 5);
            IFood bianca = new IFood(2, "bianca", "simple pizza margarita", 50, 5);
            IFood olive = new IFood(3, "olive", "simple pizza margarita with olives", 60, 10);

            this.menu.Add(margarita);
            this.menu.Add(bianca);
            this.menu.Add(olive);


        }

        public List <IFood> getMenu()
        {
            return this.menu;
        }
    }
}
