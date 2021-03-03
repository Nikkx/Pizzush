using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzush
{
    /// <summary>
    /// class that represents the plain pizza
    /// </summary>
    public class RegularCrustPizza : IPizza
    {
        int itemID;
        string name;
        string description;
        private const int cost = 20;//make consts
        int prepareTime;
        public RegularCrustPizza()
        {
            //this.itemID = id;
            //this.name = name;
            //this.cost = cost;
            //this.prepareTime = time;
            description = $"Regular Crust Pizza ({cost})";
            Console.WriteLine("Making dough...");
        }

        //return cost in shekels
        public int GetCost()
        {
            //return cost;
            return cost;
        }

        public string GetDescription()
        {
            return description;
        }

        //public int GetID()
        //{
        //    return itemID;
        //}

        //public string GetName()
        //{
        //    return name;
        //}

        /// <summary>
        /// return prepare time in minutes
        /// </summary>
        /// <returns></returns>
        public int GetPrepareTime()
        {
            //return prepareTime;
            return 8;
        }
    }
}
