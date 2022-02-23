using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicMountain
{
    class Corral : Building
    {
        Livestock[] stock = new Livestock[9];
        int availableIndex = 0;
        bool CorralFull = false;
        bool CorralEmpty = true;

        string CorralReaction;
        string CorralAlert1 = "The corral is full.";
        string CorralAlert2 = "The corral is empty.";

        bool hasMD = false;
        bool hasGreenD = false;
        bool hasGoldD = false;
        bool hasU = false;
        bool hasCC = false;

        int HowManyMD = 0;
        int HowManyGreenD = 0;
        int HowManyGoldD = 0;
        int HowManyU = 0;
        int HowManyCC = 0;

        int MDLoveCounter = 0;
        int GreenDLoveCounter = 0;
        int GoldDLoveCounter = 0;
        int ULoveCounter = 0;
        int CCLoveCounter = 0;

        //Item[] MagicGifts = new Item[9];
        //int availGiftIndex = 0;


        public bool HasMD() { return hasMD; }
        public bool HasGreenD() { return hasGreenD; }
        public bool HasGoldD() { return hasGoldD; }
        public bool HasU() { return hasU; }
        public bool HasCC() { return hasCC;}
        public void SetMD() { hasMD = true; }
        public void SetGreenD() { hasGreenD = true; }
        public void SetGoldD() { hasGoldD = true; }
        public void SetU() { hasU = true; }
        public void SetCC() { hasCC = true; }


        public void AddedMD()
        {
            SetMD();
            HowManyMD++;
        }
        public void AddedGreenD()
        {
            SetGreenD();
            HowManyGreenD++;
        }
        public void AddedGoldD()
        {
            SetGoldD();
            HowManyGoldD++;
        }
        public void AddedU()
        {
            SetU();
            HowManyU++;
        }
        public void AddedCC()
        {
            SetCC();
            HowManyCC++;
        }

        public void SoldMD()
        {
            HowManyMD--;
            if (HowManyMD == 0)
            {
                hasMD = false;
            }
        }
        public void SoldGreenD()
        {
            HowManyGreenD--;
            if (HowManyGreenD == 0)
            {
                hasGreenD = false;
            }
        }
        public void SoldGoldD()
        {
            HowManyGoldD--;
            if (HowManyGoldD == 0)
            {
                hasGoldD = false;
            }
        }
        public void SoldU()
        {
            HowManyU--;
            if (HowManyU == 0)
            {
                hasU = false;
            }
        }
        public void SoldCC()
        {
            HowManyCC--;
            if(HowManyCC == 0)
            {
                hasCC = false;
            }
        }


        public string GetCorralReaction()
        {
            return CorralReaction;
        }


        public Livestock GetStock(int num)
        {
            return stock[num];
        }

        public void NextDay()
        {
            CheckLove();
            CheckForBabies();
            //for (int i = 0; i < stock.Length; i++)
            //{
            //    if (stock[i] != null)
            //    {
            //        stock[i].SetGrowTime();
            //        stock[i].dry();

            //        if (stock[i].GetDryCounter() == 3)
            //        {
            //            stock[i] = null;
            //            CorralStock(i);
            //        }
            //    }
            //}
        }

        //public void RainDay()
        //{
        //    for (int i = 0; i < stock.Length; i++)
        //    {
        //        if (stock[i] != null)
        //        {
        //            stock[i].water();
        //        }
        //    }
        //}

        public void MDLove()
        {
            if(HowManyMD >= 2)
            {
                MDLoveCounter++;
            }
        }
        public void GreenDLove()
        {
            if (HowManyGreenD >= 2)
            {
                GreenDLoveCounter++;
            }
        }
        public void GoldDLove()
        {
            if (HowManyGoldD >= 2)
            {
                GoldDLoveCounter++;
            }
        }
        public void ULove()
        {
            if (HowManyU >= 2)
            {
                ULoveCounter++;
            }
        }
        public void CCLove()
        {
            if (HowManyCC >= 2)
            {
                CCLoveCounter++;
            }
        }

        public void CheckLove()
        {
            MDLove();
            GreenDLove();
            GoldDLove();
            ULove();
            CCLove();
        }


        public void BabyMD()
        {
            if(MDLoveCounter == 10 && CorralFull == false)
            {
                MountainDragon babyMD = new MountainDragon();
                AddStock(babyMD);
            }
        }
        public void BabyGreenD()
        {
            if (GreenDLoveCounter == 10 && CorralFull == false)
            {
                GreenDragon babyGreenD = new GreenDragon();
                AddStock(babyGreenD);
            }
        }
        public void BabyGoldD()
        {
            if (GoldDLoveCounter == 10 && CorralFull == false)
            {
                GoldDragon babyGoldD = new GoldDragon();
                AddStock(babyGoldD);
            }
        }
        public void BabyU()
        {
            if (ULoveCounter == 10 && CorralFull == false)
            {
                Unicorn babyU = new Unicorn();
                AddStock(babyU);
            }
        }
        public void BabyCC()
        {
            if (CCLoveCounter == 10 && CorralFull == false)
            {
                CocoCow babyGreenD = new CocoCow();
                AddStock(babyGreenD);
            }
        }

        public void CheckForBabies()
        {
            BabyMD();
            BabyGreenD();
            BabyGoldD();
            BabyU();
            BabyCC();
        }

        public void AddStock(Livestock _stock)
        {
            if (CorralFull == false)
            {
                stock[availableIndex] = _stock;
                availableIndex++;
                CorralEmpty = false;
                if (availableIndex > 8)
                {
                    CorralFull = true;
                }
            }
            else
            {
                CorralReaction = CorralAlert1;
            }

        }

        public void CorralStock(int num)
        {
            for (int r = num; r < stock.Length; r++)
            {
                stock[r] = stock[r + 1];
            }
            availableIndex--;
        }
        public void CheckIfEmpty()
        {
            if (stock[0] == null && stock[1] == null && stock[2] == null && stock[3] == null && stock[4] == null && stock[5] == null)
            {
                CorralEmpty = true;
            }
        }

        public Livestock SelectStock(int num)
        {
            Livestock SelectedStock = null;

            if (CorralEmpty == false)
            {
                SelectedStock = stock[num];
                stock[num] = null;
                CorralStock(num);
                CheckIfEmpty();
            }
            else
            {
                CorralReaction = CorralAlert2;
            }

            return SelectedStock;
        }

        public void ViewStock()
        {
            Console.Write("I have:");

            for (int i = 0; i < stock.Length; i++)
            {
                if (stock[i] != null)
                {
                    Console.WriteLine($" |{stock[i].GetName()}|");
                }
            }
        }
    }
}
