using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicMountain
{
    internal class Item
    {
        protected string name = "";
        protected int nutrition = 0;
        protected bool edible = false;
        protected int BuyPrice = 0;
        protected int SellPrice = 0;

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

        public int GetBuyPrice() { return BuyPrice; }
        public int GetSellPrice() { return SellPrice; }

        public void SetBuyPrice(int _BuyPrice) { BuyPrice = _BuyPrice; }
        public void SetSellPrice(int _SellPrice) { SellPrice = _SellPrice; }
    }
}
