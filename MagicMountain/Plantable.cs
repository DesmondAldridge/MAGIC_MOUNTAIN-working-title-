using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicMountain
{
    class Plantable : Item
    {
        protected bool watered = false;
        protected int dryCounter = 0;
        protected bool ripe = false;
        protected int growTime = 0;

        public bool GetRipe()
        {
            return ripe;
        }

        public void ripen()
        {
            ripe = true;
        }

        public void spoil()
        {
            ripe = false;
        }

        public bool GetWatered()
        {
            return watered;
        }
        public void water()
        {
            dryCounter = 0;
            watered = true;
        }

        public void dry()
        {
            dryCounter++;
            watered = false;
        }

        public int GetGrowTime()
        {
            return growTime;
        }
        public void SetGrowTime()
        {
            growTime++;
        }

        public int GetDryCounter()
        {
            return dryCounter;
        }
    }
}
