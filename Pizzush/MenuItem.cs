using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzush.Interfaces
{
    public class MenuItem
    {
        IFood food;
        int price;
        string name;
        int prepTime;

        public MenuItem(IFood food, int price, string name, int prepTime)
        {
            this.food = food;
            this.price = price;
            this.name = name;
            this.prepTime = prepTime;
        }

        public IFood GetFood()
        {
            return this.food;
        }

        public int GetPrice()
        {
            return this.price;
        }

        public string GetName()
        {
            return this.name;
        }

        public int GetPrepTime()
        {
            return this.prepTime;
        }
    }
}
