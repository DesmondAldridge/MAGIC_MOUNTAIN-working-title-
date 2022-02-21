using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicMountain
{
    class Wilderness : Area
    {

        public Wilderness()
        {
            areaID = "Area";
            Random totalItems = new Random();
            Random rand = new Random();
            availItems = totalItems.Next(0, 3);
            int itemRarity = rand.Next(1, 80);
            int itemRarity2 = rand.Next(1, 80);
            int itemRarity3 = rand.Next(1, 80);

            if (availItems == 1)
            {
                AreaItems = new Item[availItems];
                //Determining item
                if (itemRarity > 0 && itemRarity <= 40)
                {
                    WellnessBerry wellnessBerry = new WellnessBerry();
                    AreaItems[0] = wellnessBerry;
                } else if(itemRarity > 40 && itemRarity <= 70)
                {

                } else if(itemRarity > 70 && itemRarity <= 78)
                {
                    HealSeed healSeed = new HealSeed();
                    AreaItems[0] = healSeed;
                } else if(itemRarity > 78 && itemRarity <= 80)
                {
                    GoddessFlower goddessFlower = new GoddessFlower();
                    AreaItems[0] = goddessFlower;
                }
            }

            if (availItems == 2)
            {
                AreaItems = new Item[availItems];
                //Determining item 1/2 for array
                if (itemRarity > 0 && itemRarity <= 40)
                {
                    WellnessBerry wellnessBerry = new WellnessBerry();
                    AreaItems[0] = wellnessBerry;
                }
                else if (itemRarity > 40 && itemRarity <= 70)
                {

                }
                else if (itemRarity > 70 && itemRarity <= 78)
                {
                    HealSeed healSeed = new HealSeed();
                    AreaItems[0] = healSeed;
                }
                else if (itemRarity > 78 && itemRarity <= 80)
                {
                    GoddessFlower goddessFlower = new GoddessFlower();
                    AreaItems[0] = goddessFlower;
                }
                //Determining item 2/2 for array
                if (itemRarity2 > 0 && itemRarity2 <= 40)
                {
                    WellnessBerry wellnessBerry = new WellnessBerry();
                    AreaItems[1] = wellnessBerry;
                }
                else if (itemRarity2 > 40 && itemRarity2 <= 70)
                {

                }
                else if (itemRarity2 > 70 && itemRarity2 <= 78)
                {
                    HealSeed healSeed = new HealSeed();
                    AreaItems[1] = healSeed;
                }
                else if (itemRarity2 > 78 && itemRarity2 <= 80)
                {
                    GoddessFlower goddessFlower = new GoddessFlower();
                    AreaItems[1] = goddessFlower;
                }
            }

            if (availItems == 3)
            {
                AreaItems = new Item[availItems];
                //Determining item 1/3 for array
                if (itemRarity > 0 && itemRarity <= 40)
                {
                    WellnessBerry wellnessBerry = new WellnessBerry();
                    AreaItems[0] = wellnessBerry;
                }
                else if (itemRarity > 40 && itemRarity <= 70)
                {

                }
                else if (itemRarity > 70 && itemRarity <= 78)
                {
                    HealSeed healSeed = new HealSeed();
                    AreaItems[0] = healSeed;
                }
                else if (itemRarity > 78 && itemRarity <= 80)
                {
                    GoddessFlower goddessFlower = new GoddessFlower();
                    AreaItems[0] = goddessFlower;
                }
                //Determining item 2/3 for array
                if (itemRarity2 > 0 && itemRarity2 <= 40)
                {
                    WellnessBerry wellnessBerry = new WellnessBerry();
                    AreaItems[1] = wellnessBerry;
                }
                else if (itemRarity2 > 40 && itemRarity2 <= 70)
                {

                }
                else if (itemRarity2 > 70 && itemRarity2 <= 78)
                {
                    HealSeed healSeed = new HealSeed();
                    AreaItems[1] = healSeed;
                }
                else if (itemRarity2 > 78 && itemRarity2 <= 80)
                {
                    GoddessFlower goddessFlower = new GoddessFlower();
                    AreaItems[1] = goddessFlower;
                }
                //Determining item 3/3 for array
                if (itemRarity3 > 0 && itemRarity3 <= 40)
                {
                    WellnessBerry wellnessBerry = new WellnessBerry();
                    AreaItems[2] = wellnessBerry;
                }
                else if (itemRarity3 > 40 && itemRarity3 <= 70)
                {
                    Magshroom magshroom = new Magshroom();
                    AreaItems[2] = magshroom;
                }
                else if (itemRarity3 > 70 && itemRarity3 <= 78)
                {
                    HealSeed healSeed = new HealSeed();
                    AreaItems[2] = healSeed;
                }
                else if (itemRarity3 > 78 && itemRarity3 <= 80)
                {
                    GoddessFlower goddessFlower = new GoddessFlower();
                    AreaItems[2] = goddessFlower;
                }
            }



        }
    }
}
