using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicMountain
{
    class Game
    {
        //GAME VARIABLES
        bool isPlaying = true;

        //TIME VARIABLES
        int minutes = 0;
        int hour = 0;
        int day = 1;
        int month = 1;
        bool noon;
        bool midnight;
        bool morning;
        bool night;
        string clock;
        char moon = '☽';
        char sun = '☀';
        char currentSky;

        //WEATHER VARIABLES
        bool raining;
        bool snowing;
        bool clear;
        char rain = '☂';
        char snow = '⛇';
        string currentWeather;

        //SEASON VARIABLES
        bool spring;
        bool summer;
        bool fall;
        bool winter;
        bool thawl;
        string currentSeason;

        //LOCATION VARIABLES
        Area currentArea;
        Area previousArea;
        Place outside;
        //Wilderness
        int areaCounter = 0;
        Area[] areaArray = new Area[10];
        //bool firstArea = true;

        //HOME VARIABLES
        Place Home = new Place();
        Building Homestead = new Building();
        Building Grotto = new Building();
        Garden Garden = new Garden();

        //WOODS VARIABLES
        Place CrossTrail = new Place();
        //Place EdgeOfWilderness = new Place();

        //RAVEN FEATHER VILLAGE
        //Bottom & Top
        Place BlackwingStreet = new Place();
        Place Uptown = new Place();

        //West, Mid, & East
        Place CauldronWay = new Place();
        Place MainStreet = new Place();
        Place NightGardenLane = new Place();
        
        //Cauldron Way
        Shop Stables = new Shop();
        Shop Apocathery = new Shop();

        //North of Town
        Place FaeRiverBridge = new Place();
        Place Arbor = new Place();
        Building UnicornRanch = new Building();

        public bool GetIsPlaying()
        {
            return isPlaying; 
        }

        public void Play()
        {
            //currentArea = Apocathery;
            //EnterBuilding(Apocathery);
            //WhereAmI();
            //ExitBuilding();

            //WhereAmI();
            //ExitBuilding();
            //WhereAmI();
            CrossTrail.SetAreaID("Cross Trail");

            
            CreateArea();
            WhereAmI();
            CreateArea();
            WhereAmI();
            CreateArea();
            WhereAmI();
            CreateArea();
            WhereAmI();
            CreateArea();
            WhereAmI();
            CreateArea();
            WhereAmI();
            CreateArea();
            WhereAmI();
            CreateArea();
            WhereAmI();
            CreateArea();
            WhereAmI();
            CreateArea();
            WhereAmI();
            CreateArea();
            WhereAmI();


            GoBack();
            WhereAmI();
            GoBack();
            WhereAmI();
            GoBack();
            WhereAmI();
            GoBack();
            WhereAmI();
            GoBack();
            WhereAmI();
            GoBack();
            WhereAmI();
            GoBack();
            WhereAmI();
            GoBack();
            WhereAmI();
            GoBack();
            WhereAmI();
            GoBack();
            WhereAmI();



        }


        public void BuildWorld()
        {
            Home.SetAreaID("Home");
            CrossTrail.SetAreaID("Cross Trail");

            CauldronWay.SetAreaID("Cauldron Way");
            Apocathery.SetAreaID("Apocathery");
            UnicornRanch.SetAreaID("Unicorn Ranch");
            Apocathery.SetOutside(CauldronWay);


        }



        

        
        //public void EnterPlace(Place _place)
        //{
        //    currentArea = _place;
        //}

        public void EnterBuilding(Building _building)
        {
            previousArea = currentArea;
            outside = _building.GetOutside();
            currentArea = _building;
        }

        public void ExitBuilding()
        {
            currentArea = outside;
        }

        public void WhereAmI()
        {
            Console.WriteLine(currentArea.GetAreaID());
        }

        // MAP METHODS
        public void CreateArea()
        {
            areaCounter++;
            if (areaCounter < 11)
            {
                previousArea = currentArea;
                Wilderness createdArea = new Wilderness();
                createdArea.SetAreaID(areaCounter.ToString());
                areaArray[areaCounter - 1] = createdArea;
                currentArea = createdArea;

                //if (firstArea == true)
                //{
                //    createdArea.SetOutside(CrossTrail);
                //}else if(firstArea == false)
                //{
                //    createdArea.SetOutside(previousArea);
                //}

                SetTime();
            }
            else
            {
                Console.WriteLine("Too tired to explore new places.");
            }
        }

        public void GoBack()
        {
            string currentAreaID = currentArea.GetAreaID();
            int.TryParse(currentAreaID, out int parsedID);
            int destinationID = parsedID - 2;

            if (destinationID < 0)
            {
                currentArea = CrossTrail;
                SetTime();
            }
            else
            {
                currentArea = areaArray[destinationID];
                SetTime();
            }
        }

        //TIME METHODS
        public void SetTime()
        {
            minutes = 0;
            hour++;
            if (hour == 24)
            {
                midnight = true;
                hour = 0;
                NewDay();
            }
            else if (hour == 12)
            {
                noon = true;
            }
            else
            {
                noon = false;
                midnight = false;
            }

            SetClock();
        }

        public void SetClock()
        {
            if(noon == true)
            {
                clock = $"It's {hour} O'Clock, mid-day";
            }

            if(midnight == true)
            {
                clock = $"It's 12 O'Clock, mid-night";
            }

            if(hour > 12 && hour < 18)
            {
                clock = $"It's {hour} O'Clock in the afternoon";
            }

            if(hour >= 18 && hour < 20)
            {
                clock = $"It's {hour} O'Clock in the evening";
            }

            if(hour >= 20 && hour < 24)
            {
                clock = $"It's {hour} O'Clock at night";
            }

            if(hour > 0 && hour < 12)
            {
                clock = $"It's {hour} O'Clock in the morning";
            }

        }

        public void SetSky()
        { if(clear == true)
            {
                if (hour >= 0 && hour < 6 || hour >= 20)
                {
                    currentSky = moon;
                }
                else if (hour >= 5 && hour < 20)
                {
                    currentSky = sun;
                }
            }
            else if(raining == true)
            {
                currentSky = rain;
            }
            else if (snowing == true)
            {
                currentSky = snow;
            }
        }

        public void SetWeather()
        {
            Random forecast = new Random();
            int weather = forecast.Next(1, 10);
            if(weather >= 1 && weather < 8)
            {
                clear = true;
                raining = false;
                snowing = false;
            }
            else
            {
                clear = false;
                raining = true;
                snowing = false;
                if (winter == true)
                {
                    clear = false;
                    raining = false;
                    snowing = true;
                }
            }

            if(clear == true)
            {
                currentWeather = "Clear skies";
            }
            if(raining == true)
            {
                currentWeather = "It's raining";
            }
            if (snowing == true)
            {
                currentWeather = "It's snowing";
            }
        }

        void Action()
        {
            minutes += 10;
            if(minutes >= 60)
            {
                SetTime();
            }
        }

        //CALENDAR METHODS
        void NewDay()
        {
            day++;
            SetWeather();
            SetSky();

            if(day == 32)
            {
                NewMonth();
            }
        }

        void NewMonth()
        {
            month++;

            if(month == 13)
            {
                EndGame();
            }

            if(month <= 2)
            {
                spring = true;
                summer = false;
                fall = false;
                winter = false;
                thawl = false;

                currentSeason = "Spring";
            }

            if (month >= 3 && month <= 5)
            {
                spring = false;
                summer = true;
                fall = false;
                winter = false;
                thawl = false;

                currentSeason = "Summer";
            }

            if (month >= 6 && month <= 8)
            {
                spring = false;
                summer = false;
                fall = true;
                winter = false;
                thawl = false;

                currentSeason = "Fall";
            }

            if (month >= 9 && month <= 10)
            {
                spring = false;
                summer = false;
                fall = false;
                winter = true;
                thawl = false;

                currentSeason = "Winter";
            }

            if (month >= 11 && month <= 12)
            {
                spring = false;
                summer = false;
                fall = false;
                winter = false;
                thawl = true;

                currentSeason = "Thawl";
            }

            day = 1;
        }

        //void UpdateGarden(Garden _garden)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        _garden.
        //    }
        //}

        void EndGame()
        {
            isPlaying = false;
        }


        //        CreateArea();
        //        Console.WriteLine($"I am in area {currentArea.GetAreaID()}");
        //CreateArea();
        //        Console.WriteLine($"I am in area {currentArea.GetAreaID()}");
        //CreateArea();
        //        Console.WriteLine($"I am in area {currentArea.GetAreaID()}");
        //CreateArea();
        //        Console.WriteLine($"I am in area {currentArea.GetAreaID()}");
        //CreateArea();
        //        Console.WriteLine($"I am in area {currentArea.GetAreaID()}");
        //CreateArea();
        //        Console.WriteLine($"I am in area {currentArea.GetAreaID()}");
        //CreateArea();
        //        Console.WriteLine($"I am in area {currentArea.GetAreaID()}");
        //CreateArea();
        //        Console.WriteLine($"I am in area {currentArea.GetAreaID()}");
        //CreateArea();
        //        Console.WriteLine($"I am in area {currentArea.GetAreaID()}");
        //CreateArea();
        //        Console.WriteLine($"I am in area {currentArea.GetAreaID()}");
        //CreateArea();

        //        GoBack();
        //        Console.WriteLine($"I am in area {currentArea.GetAreaID()}");
        //GoBack();
        //        Console.WriteLine($"I am in area {currentArea.GetAreaID()}");
        //Console.WriteLine();
        //Console.WriteLine($"By the way, there are {areaArray[6].GetAvailItems()} items in area {areaArray[6].GetAreaID()}");
        //Console.WriteLine($"But {areaArray[5].GetAvailItems()} items in area {areaArray[5].GetAreaID()}.");
        //Console.WriteLine();
        //currentArea = areaArray[6];
        //Console.WriteLine($"Oh look I'm back in area {currentArea.GetAreaID()}, and there are still only {currentArea.GetAvailItems()} items here.");
        //Console.WriteLine($"Oh look I'm back in area {currentArea.GetAreaID()}, and there are still only {currentArea.GetAvailItems()} items here.");
        //Console.WriteLine($"Oh look I'm back in area {currentArea.GetAreaID()}, and there are still only {currentArea.GetAvailItems()} items here.");
        //Console.WriteLine();
        //Console.WriteLine($"It's {clock} o'clock");
        //Console.WriteLine(midnight);
        //Console.WriteLine(noon);
        //GoBack();
        //        Console.WriteLine(noon);
        //Console.WriteLine($"It's {clock} o'clock");



        //Console.WriteLine($"There are {testArea.GetAvailItems()} items available");
        //testArea.SetAvailItems();
        //testArea.SetAvailItems();
        //testArea.SetAvailItems();
        //testArea.SetAvailItems();
        //testArea.SetAvailItems();
        //testArea.SetAvailItems();
        //Console.WriteLine($"There are {testArea.GetAvailItems()} items available");
    }
}
