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
        List<IFood> menu = new List<IFood>();

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

            menu.Add(Margarita);
            menu.Add(Margot);
            menu.Add(Bianca);
            menu.Add(Pepperoni);
            menu.Add(Fungi);
        }

        public List<IFood> GetMenu()
        {
            return menu;
        }

        public IFood ConvertIdToIFood(int id)
        {
            return menu[id];
        }
    }
}
