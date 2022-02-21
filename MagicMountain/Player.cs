using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicMountain
{
    class Player
    {
        int Health = 100;
        int Energy = 100;
        int Nurishment = 100;
        int Hydration = 100;

        Item[] Bag = new Item[8];

        static public string food = "🍏";
        static public string drink = "💧";
        static public string energy = "💪";

        bool WentToBed = false;

        bool ZeroHealth = false;
        bool ZeroNurishment = false;
        bool ZeroHydration = false;

        bool PassedOut = false;
        bool Perished = false;

        //FOR DISPLAY
        string Reaction;

        string FoodStatus;
        string DrinkStatus;
        string EnergyStatus;

        //string Status = $"{food}{FoodStatus} ";

        //ALERTS
        string Notification1 = "I'm stuffed. I can't eat that now.";
        string Notification2 = "I don't think that's edible.";
        string Notification3 = "I'm not thirsty right now.";
        string Notification4 = "I don't think that's potable.";
        string Notification5 = "Yummy!";
        string Notification6 = "Ahhh. Refreshing.";

        string Alert1 = "I'm hungry. I need to eat.";
        string Alert2 = "I'm starving. I need to eat!";
        string Alert3 = "I'm thirsty. I need to drink.";
        string Alert4 = "I'm dehydrated. I need to drink!";
        string Alert5 = "I'm tired. I need to rest.";
        string Alert6 = "I'm exhausted. I need to sleep!";

        string AllGood = "";

        //GETTERS
        public string GetFoodStatus() { return FoodStatus; }
        public string GetDrinkStatus() { return DrinkStatus; }
        public string GetEnergyStatus() { return EnergyStatus; }

        public bool GetWentToBed() { return WentToBed; }
        public bool GetPassedOut() { return PassedOut;}
        public bool GetPerished() { return Perished; }
        public int GetHealth()
        {
            return Health;
        }
        public int GetEnergy()
        {
            return Energy;
        }
        public int GetNurishment()
        {
            return Nurishment;
        }
        public int GetHydration()
        {
            return Hydration;
        }

        public string GetReaction()
        {
            return Reaction;
        }

        public string GetStatus()
        {
            return $"{food}{FoodStatus} {drink}{DrinkStatus} {energy}{EnergyStatus}";
        }


        //HEALTH RELATED METHODS
        //Intake
        public void Eat(Item _item)
        {
            if(Nurishment < 100)
            {
                if (_item.GetEdible() == true)
                {
                    Nurishment += _item.GetNutrition();
                    Reaction = Notification5;
                    Health += 2;
                }
                else
                {
                    Reaction = Notification2;
                }
            }
            else
            {
                Reaction = Notification1;
            }

        }
        public void Drink(Liquid _liquid)
        {
            if (Hydration < 100)
            {
                if (_liquid.GetPotable() == true)
                {
                    Hydration += _liquid.GetHydro();
                    Reaction = Notification6;
                    Health += 2;
                }
                else
                {
                    Reaction = Notification4;
                }
            }
            else
            {
                Reaction = Notification3;
            }
        }
        public void Relax()
        {
            if(Energy <= 80)
            {
                Energy += 5;
            }
            else
            {
                Energy = Energy;
            }
            
        }
        public void Sleep()
        {
            Energy = 100;
            WentToBed = true;
        }

        public void WakeUp()
        {
            WentToBed = false;
            PassedOut = false;
        }

        //Depletion
        public void Digest()
        {
            Nurishment -= 2;
        }
        public void Dehydrate()
        {
            Hydration -= 5;
        }
        public void Exertion()
        {
            Energy -= 5;
        }


        public void UpdateStatus()
        {
            //DOING WELL
            if (Nurishment >= 50)
            {
                FoodStatus = AllGood;
            }
            if (Hydration >= 50)
            {
                DrinkStatus = AllGood;
            }
            if (Energy >= 50)
            {
                EnergyStatus = AllGood;
            }

            //DECLINING
            if (Nurishment <= 50 && Nurishment > 15)
            {
                FoodStatus = Alert1;
            }
            if (Nurishment <= 15)
            {
                FoodStatus = Alert2;
            }
            if (Hydration <= 50 && Hydration > 15)
            {
                DrinkStatus = Alert3;
            }
            if (Hydration <= 15)
            {
                DrinkStatus = Alert4;
            }
            if (Energy <= 50 && Energy > 15)
            {
                EnergyStatus = Alert5;
            }
            if(Energy <= 15)
            {
                EnergyStatus = Alert6;
            }

            if(Nurishment <= 0)
            {
                Health -= 10;
            }
            if(Hydration <= 0)
            {
                Health -= 25;
            }
            if(Energy <= 0)
            {
                Health -= 5;
                PassedOut = true;
            }

            if(Health <= 0)
            {
                Perished = true;
            }
        }

        //BAG & ITEM METHODS

        public void AdjustBag(int num)
        {
            for (int r = num; r < Bag.Length; r++)
            {
                Bag[r] = Bag[r + 1];
            }
        }

        public Item SelectItem(int num)
        {
            Item SelectedItem;
            SelectedItem = Bag[num];
            Bag[num] = null;
            AdjustBag(num);

            return SelectedItem;
        }


    }
}
