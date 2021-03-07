using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using Pizzush.Toppings;
using Pizzush.Interfaces;

namespace Pizzush
{
    public class Menu
    {
        /// <summary>
        /// List that holds all menu items
        /// </summary>
        List<MenuItem> menu = new List<MenuItem>();

        /// <summary>
        /// restaurant menu class
        /// </summary>
        public Menu()
        {
            IPizza Margarita = new Mozzarella(new TomatoSauce(new RegularCrustPizza()));
            IPizza Margot = new Mozzarella(new TomatoSauce(new ThinCrustPizza()));
            IPizza Bianca = new Mozzarella(new CreamAndTruffleSauce(new ThinCrustPizza()));
            IPizza Pepperoni = new Pepperoni(new Mozzarella(new TomatoSauce(new RegularCrustPizza())));
            IPizza Fungi = new Mushrooms(new Mozzarella(new CreamAndTruffleSauce(new ThinCrustPizza())));

            MenuItem margarita = new MenuItem(Margarita, Margarita.GetCost(), "Margarita", 10);
            MenuItem margot = new MenuItem(Margot, 60, "Margot", 15);
            MenuItem bianca = new MenuItem(Bianca, 60, "Bianca", 15);
            MenuItem pepperoni = new MenuItem(Pepperoni, 65, "Pepperoni", 15);
            MenuItem fungi = new MenuItem(Fungi, 65, "Fungi", 15);

            menu.Add(margarita);
            menu.Add(margot);
            menu.Add(bianca);
            menu.Add(pepperoni);
            menu.Add(fungi);
        }

        public List<MenuItem> GetMenu()
        {
            return menu;
        }

        public MenuItem ConvertNameToIFood(string name)
        {
            foreach (MenuItem item in menu)
            {
                if (item.GetName() == name)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
