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
        protected int availItems;
        Area myOutside;
        protected bool shopping = false;
        protected Item[] AreaItems = null;



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
        public Area GetOutside()
        {
            return myOutside;
        }
        public void SetOutside(Area _area)
        {
            myOutside = _area;
        }

        public bool CanShopHere()
        {
            return shopping;
        }

    }
}
