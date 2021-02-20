using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzush
{
    class IFood
    {
        int itemID;
        string name;
        string description;
        int cost;
        int prepareTime;
        public IFood(int id, string name, string description, int cost, int time)
        {
            this.itemID = id;
            this.name = name;
            this.description = description;
            this.cost = cost;
            this.prepareTime = time;
        }

        public int GetID()
        {
            return this.itemID;
        }

        public string GetName()
        {
            return this.name;
        }

        public string GetDescription()
        {
            return this.description;
        }

        public int GetCost()
        {
            return this.cost;
        }

        public int GetPrepareTime()
        {
            return this.prepareTime;
        }

    }
}
