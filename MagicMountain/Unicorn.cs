using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicMountain
{
    class Unicorn : Livestock
    {
        public Unicorn()
        {
            name = "Unicorn";
            BuyPrice = 500;
            SellPrice = 400;
        }
    }
}
