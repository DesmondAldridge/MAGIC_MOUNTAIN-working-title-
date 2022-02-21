using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicMountain
{
    internal class Item
    {
        protected string name;
        protected int nutrition;
        protected bool edible;

        public string GetName()
        {
            return name;
        }

        public bool GetEdible()
        {
            return edible;
        }

        public int GetNutrition()
        {
            return nutrition;
        }
    }
}
