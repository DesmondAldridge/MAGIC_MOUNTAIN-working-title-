using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicMountain
{
    class Shop : Building
    {
        protected Item[] wares = new Item[4];
        protected bool open = false;

        protected int Opens;
        protected int Closes;

        //protected int purchaseCounter = 0;
        //protected int purchaseLimit = 0;
        public Shop()
        {
            shopping = true;
        }

        public string GetWares()
        {
            return $"{wares[0].GetName()}, {wares[1].GetName()}, & {wares[2].GetName()}";
        }

        public Item GetWare1()
        {
            return wares[0];
        }
        public Item GetWare2()
        {
            return wares[1];
        }
        public Item GetWare3()
        {
            return wares[2];
        }
        public Item GetWare4()
        {
            return wares[3];
        }

        public bool GetOpen()
        {
            return open;
        }

        public void SetWares(Item _item1, Item _item2, Item _item3, Item _item4)
        {
            wares[0] = _item1;
            wares[1] = _item2;
            wares[2] = _item3;
            wares[3] = _item4;
        }

        public void HoursOfOperation(int _openHour, int _closeHour)
        {
            Opens = _openHour;
            Closes = _closeHour;
        }

        public void Operational(int _currentTime)
        {
            if(_currentTime < Opens || _currentTime > Closes)
            {
                open = false;
            }
            else
            {
                open = true;
            }
        }

        //public void bought()
        //{
        //    purchaseCounter++;
        //    if(purchaseCounter == purchaseLimit)
        //    {

        //    }
        //}
    }
}
