using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzush
{
    public class Menu
    {
        List<IFood> menu = new List<IFood>();

        public Menu()
        {
            //IFood margarita = new IFood(1, "margarita", "simple pizza margarita", 50, 5);
            //IFood bianca = new IFood(2, "bianca", "simple pizza margarita", 50, 5);
            //IFood olive = new IFood(3, "olive", "simple pizza margarita with olives", 60, 10);

            //this.menu.Add(margarita);
            //this.menu.Add(bianca);
            //this.menu.Add(olive);

            ///READDDDDDDDDDDDDDDDDDDDDD!!!
            ///so we can do it like you did here, just with stupid decorator, and add those to the enum, or maybe we shoyld use id? IDK ANYMOREEEE
            IPizza Margarita = new Mozzarella(new TomatoSauce(new RegularCrustPizza()));
            IPizza Margot = new Mozzarella(new TomatoSauce(new ThinCrustPizza()));

        }

        public PizzaMenuEnum[] GetMenu()
        {
            // return this.menu;
            //Enum.GetValues(typeof(SomeEnum)).Cast<SomeEnum>();
             return (PizzaMenuEnum[])Enum.GetValues(typeof(PizzaMenuEnum));
            //return Enum.GetNames(typeof(PizzaMenuEnum));
            //return PizzaMenuEnum;
        }

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

        public enum PizzaMenuEnum
        {
            //crusts
            RegularCrustPizza,
            //toppings
            Mozzarella,
            TomatoSauce,
        }

        //public static class PizzaMenuEnum
        //{
        //    //crusts
        //    public const int RegularCrustPizza = 0;
        //    //toppings
        //    public const int Mozzarella = 1;
        //    public const int TomatoSauce = 2;

        //}
    }
}
