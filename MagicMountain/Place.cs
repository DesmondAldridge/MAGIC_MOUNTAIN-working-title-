using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicMountain
{
    class Place : Area
    {
        Building building1;
        Building building2;
        Building building3;
        Building building4;
        Building building5;
        Building building6;

        public Building GetBuilding1()
        {
            return building1;
        }
        public Building GetBuilding2()
        {
            return building2;
        }
        public Building GetBuilding3()
        {
            return building3;
        }
        public Building GetBuilding4()
        {
            return building4;
        }
        public Building GetBuilding5()
        {
            return building5;
        }
        public Building GetBuilding6()
        {
            return building6;
        }
        public void SetBuilding1(Building _building)
        {
            building1 = _building;
        }
        public void SetBuilding2(Building _building)
        {
            building2 = _building;
        }
        public void SetBuilding3(Building _building)
        {
            building3 = _building;
        }
        public void SetBuilding4(Building _building)
        {
            building4 = _building;
        }
        public void SetBuilding5(Building _building)
        {
            building5 = _building;
        }
        public void SetBuilding6(Building _building)
        {
            building6 = _building;
        }
    }
}
