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
        public string GetDescription();
        public int GetCost();
        public int GetPrepareTime();

    }
}
