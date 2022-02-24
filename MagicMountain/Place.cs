using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicMountain
{
    class Place : Area
    {
        Building[] BuildingsHere = new Building[4];


        public Building GetBuilding1()
        {
            return BuildingsHere[0];
        }

        public Building GetBuilding2()
        {
            return BuildingsHere[1];
        }

        public Building GetBuilding3()
        {
            return BuildingsHere[2];
        }
        public Building GetBuilding4()
        {
            return BuildingsHere[3];
        }

        public string ViewPlace()
        {
            return $"{BuildingsHere[0].GetAreaID()}, {BuildingsHere[1].GetAreaID()}, {BuildingsHere[2].GetAreaID()}, & {BuildingsHere[3].GetAreaID()}";

        }
        public void SetBuildings(Building _building1, Building _building2, Building _building3, Building _building4/*, Place _this*/)
        {
            BuildingsHere[0] = _building1;
            BuildingsHere[1] = _building2;
            BuildingsHere[2] = _building3;
            BuildingsHere[3] = _building4;

            BuildingsHere[0].SetOutside(this);
            BuildingsHere[1].SetOutside(this);
            BuildingsHere[2].SetOutside(this);
            BuildingsHere[3].SetOutside(this);
        }

    }
}
