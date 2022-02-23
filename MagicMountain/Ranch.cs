using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicMountain
{
    class Ranch : Shop
    {
        Livestock[] stock = new Livestock[5];
        Unicorn unicorn = new Unicorn();
        CocoCow cococow = new CocoCow();
        MountainDragon mountainDragon = new MountainDragon();
        GreenDragon greenDragon = new GreenDragon();
        GoldDragon goldDragon = new GoldDragon();

        public string GetStock()
        {
            return $"{stock[0].GetName()}, {stock[1].GetName()}, {stock[2].GetName()}, {stock[3].GetName()}, & {stock[4].GetName()}";
        }

        public Livestock GetStock1()
        {
            return stock[0];
        }
        public Livestock GetStock2()
        {
            return stock[1];
        }
        public Livestock GetStock3()
        {
            return stock[2];
        }
        public Livestock GetStock4()
        {
            return stock[3];
        }
        public Livestock GetStock5()
        {
            return stock[4];
        }


        public void SetStock()
        {
            stock[0] = unicorn;
            stock[1] = cococow;
            stock[2] = mountainDragon;
            stock[3] = greenDragon;
            stock[4] = goldDragon;
        }
    }
}
