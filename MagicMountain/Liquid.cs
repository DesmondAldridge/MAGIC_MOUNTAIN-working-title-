using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicMountain
{
    class Liquid
    {
        protected int hydro;
        protected bool potable;

        public int GetHydro() 
        { 
            return hydro; 
        }
        public bool GetPotable()
        {
            return potable;
        }

    }
}
