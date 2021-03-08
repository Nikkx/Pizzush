using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using Pizzush.Toppings;
using Pizzush.Interfaces;

namespace Pizzush
{
    /// <summary>
    /// restaurant menu class
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// List that holds all menu items
        /// </summary>
        List<IFood> MenuList = new List<IFood>();

        public Menu()
        {
            IPizza Margarita = new Mozzarella(new TomatoSauce(new RegularCrustPizza()));
            IPizza Margot = new Mozzarella(new TomatoSauce(new ThinCrustPizza()));
            IPizza Bianca = new Mozzarella(new CreamAndTruffleSauce(new ThinCrustPizza()));
            IPizza Pepperoni = new Pepperoni(new Mozzarella(new TomatoSauce(new RegularCrustPizza())));
            IPizza Fungi = new Mushrooms(new Mozzarella(new CreamAndTruffleSauce(new ThinCrustPizza())));

            MenuList.Add(Margarita);
            MenuList.Add(Margot);
            MenuList.Add(Bianca);
            MenuList.Add(Pepperoni);
            MenuList.Add(Fungi);
        }

        /// <summary>
        /// Get menu list
        /// </summary>
        /// <returns></returns>
        public List<IFood> GetMenu()
        {
            return MenuList;
        }

        /// <summary>
        /// Convert Id To IFood
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IFood ConvertIdToIFood(int id)
        {
            return MenuList[id];
        }
    }
}
