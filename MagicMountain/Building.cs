using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicMountain
{
    class Building : Area
    {
        Place myOutside;
        public Building()
        {
            availItems = 0;
        }

        public Place GetOutside()
        {
            return myOutside;
        }
        public void SetOutside(Place _place)
        {
            myOutside = _place;
        }
    }
}
