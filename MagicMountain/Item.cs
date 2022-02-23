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
        protected int price;

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

        public int GetPrice()
        {
            return price;
        }
    }
}
