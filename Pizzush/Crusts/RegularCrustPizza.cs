using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzush
{
    /// <summary>
    /// class that represents the regular crust pizza
    /// </summary>
    public class RegularCrustPizza : IPizza
    {
        string Description;
        private const int Cost = 20;

        public RegularCrustPizza()
        {
            Description = $"Regular Crust Pizza ({Cost})";
        }

        //return cost in shekels
        public int GetCost()
        {
            return Cost;
        }

        public string GetDescription()
        {
            return Description;
        }

        /// <summary>
        /// return prepare time in minutes
        /// </summary>
        /// <returns></returns>
        public int GetPrepareTime()
        {
            return 8;
        }
    }
}
