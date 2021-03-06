using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicMountain
{
    class Area
    {
        protected string areaID;
        protected string areaDescription;
        protected int availItems;
        protected bool shopping = false;
        protected Item[] AreaItems = null;

        public string GetDescription()
        {
            return areaDescription;
        }
        public void SetDescription(string _description)
        {
            areaDescription = _description;
        }

        //ITEMS METHODS
        public int GetAvailItems()
        {
            return availItems;
        }
        public void SetAvailItems()
        {
            availItems--;
        }
        //ID METHODS
        public string GetAreaID()
        {
            return areaID;
        }
        public void SetAreaID(string _ID)
        {
            areaID = _ID;
        }

        public bool CanShopHere()
        {
            return shopping;
        }

    }
}
