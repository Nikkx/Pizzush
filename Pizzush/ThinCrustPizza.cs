﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzush
{
    public class ThinCrustPizza : IPizza
    {
        string description;
        private const int cost = 20;//make consts

        public ThinCrustPizza()
        {
            description = $"Thin Crust Pizza ({cost})";
            Console.WriteLine("Making dough...");
        }
        public int GetCost()
        {
            return cost;
        }

        public string GetDescription()
        {
            return description;
        }

        public int GetPrepareTime()
        {
            return 8;
        }
    }
}
