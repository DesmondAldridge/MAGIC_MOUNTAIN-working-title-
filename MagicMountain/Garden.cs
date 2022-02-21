using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicMountain
{
    class Garden : Area
    {
        Plantable[] Plots = new Plantable[6];
        int availableIndex = 0;
        bool GardenFull = false;


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
            Plots[availableIndex] = _seed;
            availableIndex++;
            if(availableIndex > 5)
            {
                GardenFull = true;
            }
        }

        public void RotateCrops(int num)
        {
            for (int r = num; r < Plots.Length; r++)
            {
                Plots[r] = Plots[r + 1];
            }
        }

        public Plantable SelectCrop(int num)
        {
            Plantable SelectedCrop;
            SelectedCrop = Plots[num];
            Plots[num] = null;
            RotateCrops(num);

            return SelectedCrop;
        }

        public void ViewPlots()
        {
            Console.Write("You are growing:");

            for (int i = 0; i < Plots.Length; i++)
            {
                if (Plots[i] != null)
                {
                    Console.WriteLine($"{Plots[i].GetName()}");
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
