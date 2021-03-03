using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzush
{
    /// <summary>
    /// IFood interface - for a generic food item
    /// </summary>
    public interface IFood
    {
        //int itemID;
        //string name;
        //string description;
        //int cost;
        //int prepareTime;
        //public IFood(int id, string name, string description, int cost, int time)
        //{
        //    this.itemID = id;
        //    this.name = name;
        //    this.description = description;
        //    this.cost = cost;
        //    this.prepareTime = time;
        //}

       // public int GetID();

        //public string GetName();

        public string GetDescription();

        public int GetCost();

        public int GetPrepareTime();

    }
}
