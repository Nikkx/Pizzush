using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzush
{
    /// <summary>
    /// Thin Crust
    /// </summary>
    public class ThinCrustPizza : IPizza
    {
        string Description;
        private const int Cost = 20;

        public ThinCrustPizza()
        {
            Description = $"Thin Crust Pizza";
        }
        public int GetCost()
        {
            return Cost;
        }

        public string GetDescription()
        {
            return Description;
        }

        public int GetPrepareTime()
        {
            return 8;
        }
    }
}
