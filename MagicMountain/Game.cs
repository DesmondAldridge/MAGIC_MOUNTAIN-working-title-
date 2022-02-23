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
        char timeSym = '⌛';
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

        //PLAYER VARIABLES
        Player player = new Player();
        string thoughts = "💭";
        string currentView;

        string PermaOptions = "Please Choose: '1' Eat, '2' Drink, '3' Cancel";

        //string MakingSelection = "Scroll through by pressing '8' & hit enter to select";
        //string Selected;
        //string Option1;
        //string Option2;
        //string Option3;
        //string Option4;
        //string Option5;
        //string Option6;
        //string Option7;
        //string Option8;
        //string Option9;

        //OPTIONS VARIABLES
        string currentOptions;

        //LOCATION VARIABLES
        Area currentArea;
        Area previousArea;
        Place outside;

        //Wilderness
        int areaCounter = 0;
        Area[] areaArray = new Area[10];
        bool inWilderness = false;

        string WildernessOptions = "Please Choose: '1' Go west into more wilderness, '2' Go east the way you came, '3' View nearby items, '4' Forage item, '5' Refresh";

        //HOME VARIABLES
        Place Home = new Place();
        Building Homestead = new Building();
        Building Grotto = new Building();
        Garden HomeGarden = new Garden();
        Corral HomeCorral = new Corral();

        string HomeOptions = "Please Choose: '1' Enter your home, '2' Enter your garden, '3' Enter your corral, '4' Enter woods, '5' Refresh";
        string HomeSteadOptions = "Please Choose: '1' Go to bed, '2' Exit home, '3' Refresh";
        string GardenOptions = "Please Choose: '1' View garden, '2' Water your crops, '3' Plant a seed, '4' Harvest a crop, '5' Exit garden, '6' Refresh";
        string CorralOptions = "Please Choose: '1' View corral, '2' Stable new stock, '3' Take an animal with you, '4' Exit corral, '5' Refresh";

        string GardenSecondaryOptions = $"Please select which seed you would like plant: ";
        string GardenTertiaryOptions = $"Please select which crop you would like to harvest: ";
        string CorralSecondaryOptions = $"Please select which animal you would like stable: ";
        string CorralTertiaryOptions = $"Please select which animal you would like to take with you: ";

        //WOODS VARIABLES
        Place CrossTrail = new Place();

        string CrossTrailOptions = "Please Choose: '1' Go west into the wilderness, '2' Go north into town, '3' Go south back home";

        //RAVEN FEATHER VILLAGE
        //Bottom & Top
        Place BlackwingStreet = new Place();
        Place Uptown = new Place();

        string BlackwingStreetOptions = "Please Choose: '1' Enter Cauldron Way, '2' Enter Main Street, '3' Enter Night Garden Lane, '4' Exit town due south";
        string UptownOptions;

        //West, Mid, & East
        Place CauldronWay = new Place();
        Place MainStreet = new Place();
        Place NightGardenLane = new Place();

        string CauldronWayOptions = "Please Choose: '1' Apocathery, '2' Head uptown, '3' Head south back to Blackwing Street";
        string MainStreetOptions = "Please Choose: '1' Head uptown, '2' Head south back to Blackwing Street";
        string NightGardenLaneOptions = "Please Choose: '1' Head uptown, '2' Head south back to Blackwing Street";

        //Cauldron Way
        Shop Stables = new Shop();
        Shop Apocathery = new Shop();

        string ApocatheryOptions = "Please Choose: '1' Buy items, '2' Sell items, '3' Exit apocathery";

        //North of Town
        Place FaeRiverBridge = new Place();
        Place Arbor = new Place();
        Ranch UnicornRanch = new Ranch();

        string FaeRiverBridgeOptions;
        string ArboOptions;
        string UnicornRanchOptions;

        public bool GetIsPlaying()
        {
            return isPlaying; 
        }

        public void Play()
        {

            

            




        }

        //SETUP
        public void SetUpCrossTrail()
        {
            CrossTrail.SetAreaID("Cross Trail");
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

        public void UpdateDisplay()
        {
            Console.Clear();
            Console.WriteLine($"{timeSym} {clock}");
            Console.WriteLine($"{currentSky} {currentWeather}");
            Console.WriteLine();
            Console.WriteLine($"Current Location: {currentArea.GetAreaID()}");
            Console.WriteLine($"{currentArea.GetDescription()}");
            Console.WriteLine();
            Console.WriteLine($"{thoughts} {player.GetReaction()}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($" Computer                     cards()");
        }

        public void DisplayOptions()
        {
            ToTheBottom();
            if(currentArea == Home)
            {
                OptionsHome();
            }
            if (currentArea == Homestead)
            {
                OptionsHomestead();
            }
            if (currentArea == HomeGarden)
            {
                OptionsGarden();
            }
            if (currentArea == HomeCorral)
            {
                OptionsCorral();
            }
            if (currentArea == CrossTrail)
            {
                OptionsCrossTrail();
            }
            if(inWilderness == true)
            {
                OptionsWilderness();
            }
            if (currentArea == BlackwingStreet)
            {
                OptionsBlackwingStreet();
            }
            if (currentArea == MainStreet)
            {
                OptionsMainStreet();
            }
            if (currentArea == NightGardenLane)
            {
                OptionsNightGardenLane();
            }
            if (currentArea == Apocathery)
            {
                OptionsApocathery();
            }
            if (currentArea == FaeRiverBridge)
            {
                OptionsFaeRiverBridge();
            }
            if (currentArea == Arbor)
            {
                OptionsArbor();
            }
            if (currentArea == UnicornRanch)
            {
                OptionsUnicornRanch();
            }
            if (currentArea == UnicornRanch)
            {
                OptionsUnicornRanch();
            }
        }


        //OPTIONS METHODS
        public void OptionsHome()
        {

        }
        public void OptionsHomestead()
        {

        }
        public void OptionsGarden()
        {

        }
        public void OptionsCorral()
        {

        }
        public void OptionsCrossTrail()
        {

        }
        public void OptionsWilderness()
        {

        }
        public void OptionsBlackwingStreet()
        {

        }
        public void OptionsMainStreet()
        {

        }
        public void OptionsNightGardenLane()
        {

        }
        public void OptionsApocathery()
        {

        }
        public void OptionsFaeRiverBridge()
        {

        }
        public void OptionsArbor()
        {

        }
        public void OptionsUnicornRanch()
        {

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

                inWilderness = true;

                //if (firstArea == true)
                //{
                //    createdArea.SetOutside(CrossTrail);
                //}else if(firstArea == false)
                //{
                //    createdArea.SetOutside(previousArea);
                //}

                Action();
            }
            else
            {
                thoughts = "Too tired to explore new places.";
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
                inWilderness = false;
                Action();
            }
            else
            {
                currentArea = areaArray[destinationID];
                Action();
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
            SetSky();
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

            if (day == 32)
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

        public void ToTheBottom()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }

        void EndGame()
        {
            isPlaying = false;
        }

        public void myDeBug()
        {
            //currentArea = Apocathery;
            //EnterBuilding(Apocathery);
            //WhereAmI();
            //ExitBuilding();

            //WhereAmI();
            //ExitBuilding();
            //WhereAmI();

            

            //CreateArea();
            //WhereAmI();
            //CreateArea();
            //WhereAmI();
            //CreateArea();
            //WhereAmI();
            //CreateArea();
            //WhereAmI();
            //CreateArea();
            //WhereAmI();
            //CreateArea();
            //WhereAmI();
            //CreateArea();
            //WhereAmI();
            //CreateArea();
            //WhereAmI();
            //CreateArea();
            //WhereAmI();
            //CreateArea();
            //WhereAmI();
            //CreateArea();
            //WhereAmI();


            //GoBack();
            //WhereAmI();
            //GoBack();
            //WhereAmI();
            //GoBack();
            //WhereAmI();
            //GoBack();
            //WhereAmI();
            //GoBack();
            //WhereAmI();
            //GoBack();
            //WhereAmI();
            //GoBack();
            //WhereAmI();
            //GoBack();
            //WhereAmI();
            //GoBack();
            //WhereAmI();
            //GoBack();
            //WhereAmI();
        }
    }
}
