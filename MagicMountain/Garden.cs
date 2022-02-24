using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicMountain
{
    class Garden : Building
    {
        Plantable[] Plots = new Plantable[6];
        int availableIndex = 0;
        bool GardenFull = false;
        bool GardenEmpty = true;

        string GardeningReaction;
        string GardenAlert1 = "The garden is full.";
        string GardenAlert2 = "The garden is empty.";

        public string GetGardeningReaction()
        {
            return GardeningReaction;
        }


        public Plantable GetPlot(int num)
        {
            return Plots[num];
        }

        public void NextDay()
        {
            for(int i = 0; i < Plots.Length; i++)
            {
                if(Plots[i] != null)
                {
                    Plots[i].SetGrowTime();
                    Plots[i].dry();

                    if(Plots[i].GetDryCounter() == 3)
                    {
                        Plots[i] = null;
                        RotateCrops(i);
                    }
                }
            }
        }

        public void RainDay()
        {
            for (int i = 0; i < Plots.Length; i++)
            {
                if (Plots[i] != null)
                {
                    Plots[i].water();
                }
            }
        }

        public void Plant(Plantable _seed)
        {
            if(GardenFull == false)
            {
                Plots[availableIndex] = _seed;
                availableIndex++;
                GardenEmpty = false;
                if (availableIndex > 5)
                {
                    GardenFull = true;
                }
            }
            else
            {
                GardeningReaction = GardenAlert1;
            }

        }

        public void RotateCrops(int num)
        {
            for (int r = num; r < Plots.Length; r++)
            {
                Plots[r] = Plots[r + 1];
            }
            availableIndex--;
        }
        public void CheckIfEmpty()
        {
            if (Plots[0] == null && Plots[1] == null && Plots[2] == null && Plots[3] == null && Plots[4] == null && Plots[5] == null)
            {
                GardenEmpty = true;
            }
        }

        public Plantable SelectCrop(int num)
        {
            Plantable SelectedCrop = null;

            if (GardenEmpty == false)
            {
                SelectedCrop = Plots[num];
                Plots[num] = null;
                RotateCrops(num);
                CheckIfEmpty();
            }
            else
            {
                GardeningReaction = GardenAlert2;
            }

            return SelectedCrop;
        }

        public void WaterGarden()
        {
            for (int i = 0; i < Plots.Length; i++)
            {
                if (Plots[i] != null)
                {
                    Plots[i].water();
                }
            }
        }

        public void ViewPlots()
        {
            Console.Write("I'm growing:");

            for (int i = 0; i < Plots.Length; i++)
            {
                if (Plots[i] != null)
                {
                    Console.Write($" |{Plots[i].GetName()}|");
                }
            }

            //if (Plots[0] != null)
            //{
            //    Console.Write($"{Plots[0].GetName()}");
            //}
            //if (Plots[1] != null)
            //{
            //    Console.Write($", {Plots[1].GetName()}");
            //}
            //if (Plots[2] != null)
            //{
            //    Console.Write($", {Plots[2].GetName()}");
            //}
            //if (Plots[3] != null)
            //{
            //    Console.Write($", {Plots[3].GetName()}");
            //}
            //if (Plots[4] != null)
            //{
            //    Console.Write($", {Plots[4].GetName()}");
            //}
            //if (Plots[5] != null)
            //{
            //    Console.Write($", {Plots[5].GetName()}");
            //}

        }


    }
}
