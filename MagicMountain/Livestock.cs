using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicMountain
{
    class Livestock
    {
        protected string name = "";
        protected int BuyPrice = 0;
        protected int SellPrice = 0;

        //protected bool watered = false;
        //protected int dryCounter = 0;

        //protected bool ripe = false;
        //protected bool spoiled = false;

        //protected int growCounter = 0;
        //protected int ripenTime = 0;
        //protected int decayCounter = 0;
        //protected int decayTime = 0;


        //protected string seedling = "";
        //protected string produce = "";

        public string GetName() { return name; }
        public int GetBuyPrice() { return BuyPrice; }
        public int GetSellPrice() { return SellPrice; }

        public void SetBuyPrice(int _BuyPrice) { BuyPrice = _BuyPrice; }
        public void SetSellPrice(int _SellPrice) { SellPrice = _SellPrice; }



        //public bool GetRipe()
        //{
        //    return ripe;
        //}

        //public void SetRipen(int _num)
        //{
        //    ripenTime = _num;
        //}

        //public void SetDecay(int _num)
        //{
        //    ripenTime = _num;
        //}

        //public void ripen()
        //{
        //    ripe = true;
        //}

        //public void spoil()
        //{
        //    spoiled = true;
        //}

        //public bool GetSpoiled()
        //{
        //    return spoiled;
        //}

        //public bool GetWatered()
        //{
        //    return watered;
        //}
        //public void water()
        //{
        //    dryCounter = 0;
        //    watered = true;
        //}

        //public void dry()
        //{
        //    dryCounter++;
        //    watered = false;
        //}

        //public int GetGrowTime()
        //{
        //    return growCounter;
        //}
        //public void SetGrowTime()
        //{
        //    growCounter++;

        //    if (growCounter == ripenTime)
        //    {
        //        ripen();
        //    }

        //    Expiration();
        //}

        //public void Expiration()
        //{
        //    if (ripe == true)
        //    {
        //        decayCounter++;

        //        if (decayCounter == decayTime)
        //        {
        //            spoil();
        //        }
        //    }
        //}

        //public int GetDryCounter()
        //{
        //    return dryCounter;
        //}
    }
}
