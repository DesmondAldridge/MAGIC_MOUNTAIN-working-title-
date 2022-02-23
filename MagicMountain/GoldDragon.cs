using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicMountain
{
    class GoldDragon : Livestock
    {
        public GoldDragon()
        {
            name = "Golden Dragon";
            BuyPrice = 3000;
            SellPrice = 2600;
        }
    }
}
