using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using Pizzush.Toppings;

namespace Pizzush
{
    public class Menu
    {
        List<IFood> PizzaMenu = new List<IFood>();

        public Menu()
        {
            //IFood margarita = new IFood(1, "margarita", "simple pizza margarita", 50, 5);
            //IFood bianca = new IFood(2, "bianca", "simple pizza margarita", 50, 5);
            //IFood olive = new IFood(3, "olive", "simple pizza margarita with olives", 60, 10);

            //this.menu.Add(margarita);
            //this.menu.Add(bianca);
            //this.menu.Add(olive);

            IPizza Margarita = new Mozzarella(new TomatoSauce(new RegularCrustPizza()));
            IPizza Margot = new Mozzarella(new TomatoSauce(new ThinCrustPizza()));
            IPizza Bianca = new Mozzarella(new CreamAndTruffleSauce(new ThinCrustPizza()));
            IPizza Pepperoni = new Pepperoni(new Mozzarella(new TomatoSauce(new RegularCrustPizza())));
            IPizza Fungi = new Mushrooms(new Mozzarella(new CreamAndTruffleSauce(new ThinCrustPizza())));

            string name = Margarita.GetType().Name;
            //todo if this doesnt work - create tuple (3) dictionary {id,name,IFood}

            //todo add pizzas to menu maybe find a smarter way?

        }

        public List<IFood> GetMenu()
        {
             return PizzaMenu;
            //Enum.GetValues(typeof(SomeEnum)).Cast<SomeEnum>();
            //return (PizzaMenuEnum[])Enum.GetValues(typeof(PizzaMenuEnum));
            //return Enum.GetNames(typeof(PizzaMenuEnum));
            //return PizzaMenuEnum;
        }

        //maybe not needed
        private List<IFood> ConvertEnumToFood()
        {
            List<IFood> foodList = new List<IFood>();
            //get all items on menu
            PizzaMenuEnum[] menu = (PizzaMenuEnum[])Enum.GetValues(typeof(PizzaMenuEnum));
            foreach(PizzaMenuEnum item in menu)
            {
                Type t = Type.GetType(item.ToString());
                IFood food = (IFood)Activator.CreateInstance(t);
                foodList.Add( food);
            }
            return foodList;
        }

        //
        public enum PizzaMenuEnum
        {
            ////crusts
            //RegularCrustPizza,
            ////toppings
            //Mozzarella,
            //TomatoSauce,

            Margarita,
            Margot
        }

        //public static class PizzaMenu
        //{
        //    public static IPizza Margarita = new Mozzarella(new TomatoSauce(new RegularCrustPizza()));
        //    public static IPizza Margot = new Mozzarella(new TomatoSauce(new ThinCrustPizza()));

        //}
    }
}
