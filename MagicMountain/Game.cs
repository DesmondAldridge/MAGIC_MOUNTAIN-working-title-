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
        bool SetUp = true;

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
        string currentPlayerStatus;

        string RefreshOptions = "Please Choose: '1' Eat, '2' Drink, '3' Cancel";
        string WhichItemToEat = "Please select item from your bag to eat";

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
        Building HomeWell = new Building();

        string HomeOptions = "Please Choose: '1' Enter your home, '2' Enter your garden, '3' Enter your corral, '4' Enter woods, '5' Refresh";
        string HomeSteadOptions = "Please Choose: '1' Go to bed, '2' Exit home, '3' Refresh";
        string GardenOptions = "Please Choose: '1' Water your crops, '2' Plant a seed, '3' Harvest a crop, '4' Exit garden, '5' Refresh";
        string CorralOptions = "Please Choose: '1' View corral, '2' Stable new stock, '3' Take an animal with you, '4' Exit corral, '5' Refresh";
        string WellOptions;

        string GardenSecondaryOptions = $"Please select which seed you would like plant: ";
        string GardenTertiaryOptions = $"Please select which crop you would like to harvest: ";
        string CorralSecondaryOptions = $"Please select which animal you would like stable: ";
        string CorralTertiaryOptions = $"Please select which animal you would like to take with you: ";

        //WOODS VARIABLES
        Place CrossTrail = new Place();

        string CrossTrailOptions = "Please Choose: '1' Go west into the wilderness, '2' Go north into town, '3' Go south back home, '4' Refresh";

        //RAVEN FEATHER VILLAGE
        //Bottom & Top
        Place BlackwingStreet = new Place();
        Place Uptown = new Place();

        string BlackwingStreetOptions = "Please Choose: '1' Enter Cauldron Way, '2' Enter Main Street, '3' Enter Night Garden Lane, '4' Exit town due south, '5' Refresh";
        string UptownOptions = "Please Choose: '1' Go north of town, '2' Back to Cauldron Way, '3' Back to Main Street, '4' Back to Night Garden Lane, '5' Refresh";

        //West, Mid, & East
        Place CauldronWay = new Place();
        Place MainStreet = new Place();
        Place NightGardenLane = new Place();

        string CauldronWayOptions = "Please Choose: '1' Apocathery, '2' Head uptown, '3' Head south back to Blackwing Street, '4' Refresh";
        string MainStreetOptions = "Please Choose: '1' Head uptown, '2' Head south back to Blackwing Street, '3' Refresh";
        string NightGardenLaneOptions = "Please Choose: '1' Head uptown, '2' Head south back to Blackwing Street, '3' Refresh";

        //Cauldron Way
        Shop Stables = new Shop();
        Shop Smithy = new Shop();
        Shop Apocathery = new Shop();
        Shop SorceryShop = new Shop();

        string ApocatheryOptions = "Please Choose: '1' Buy items, '2' Sell items, '3' Exit apocathery";
        string ApocatheryBuyOptions = $"What would you like to buy? '1' , '2' , '3', '4'";
        string ApocatherySellOptions = $"What would you like to sell? '1' , '2' , '3', '4', '5', '6', '7', '8'";

        //Main Street
        Shop Flowershop = new Shop();
        Shop Bakery = new Shop();
        Shop GardenSupplies = new Shop();
        Shop Cafe = new Shop();

        //North of Town
        Place FaeRiverBridge = new Place();
        Place Arbor = new Place();
        Ranch UnicornRanch = new Ranch();
        Building Lodge = new Building();
        Building MayorManse = new Building();
        Ranch FestivalGrounds = new Ranch();

        string FaeRiverBridgeOptions = "Please Choose: '1' Go north to the Arbor District, '2' Head back south into town, '3' Refresh";
        string ArborOptions = "Please Choose: '1' Enter Unicorn Ranch, '2' Head back south, '3' Refresh";
        string UnicornRanchOptions;
        string FestivalGroundOptions;

        public bool GetIsPlaying()
        {
            return isPlaying; 
        }

        public void Play()
        {

            Initiate();
            UpdateDisplay();

            




        }

        //SETUP
        public void SetUpHome()
        {
            Home.SetAreaID("Home");
            Home.SetDescription("Home sweet home!");
            Home.SetBuildings(Homestead, HomeGarden, HomeCorral, HomeWell);

            Homestead.SetAreaID("House");
            HomeGarden.SetAreaID("Garden");
            HomeCorral.SetAreaID("Corral");
            HomeWell.SetAreaID("Well");

            Homestead.SetDescription("My beautiful homestead underneath a hill... comfy chair, roaring fireplace, tree roots for a ceiling... so cozy!");
            HomeGarden.SetDescription("My humble little garden, where I can grow magical produce.");
            HomeCorral.SetDescription("My corral, where I keep & breed magical livestock.");
            HomeWell.SetDescription("My old family well.");
        }
        public void SetUpCrossTrail()
        {
            CrossTrail.SetAreaID("Cross Trail");
            CrossTrail.SetDescription("Sign post reads: 'Wilderness to the east', 'Dragon cave to the west' & 'Raventree Village to the north'...");
        }

        public void SetUpRaventreeVillage()
        {
            BlackwingStreet.SetAreaID("Blackwing Street");
            CauldronWay.SetAreaID("Cauldron Way");
            MainStreet.SetAreaID("MainStreet");
            NightGardenLane.SetAreaID("Night Garden Lane");
            Uptown.SetAreaID("Uptown");

            BlackwingStreet.SetDescription("The cross town street that spans the southern edge of town.");
            CauldronWay.SetDescription("Western most avenue of town. A lot of trade and craft persons have set up shop here.");
            MainStreet.SetDescription("Middle most avenue of town. This is where I'll find plant & produce related shops.");
            NightGardenLane.SetDescription("Eastern most avenue of town. Nothing here but fancy residents.");
            Uptown.SetDescription("The northern edge of town. Looks like Town Hall, the Green Door Tavern, Church, & Library are all closed!");

            CauldronWay.SetBuildings(Stables, Smithy, Apocathery, SorceryShop);
            MainStreet.SetBuildings(GardenSupplies, Flowershop, Bakery, Cafe);

            Apocathery.SetAreaID("Apocathery");
            Apocathery.SetDescription("Ah, I love the calming sound of bubbling cauldrons.");
            Apocathery.Operational(hour);
            Apocathery.HoursOfOperation(9, 17);


        }
        public void SetUpArbor()
        {
            FaeRiverBridge.SetAreaID("Fae River Bridge");
            FaeRiverBridge.SetDescription("The old wooden bridge amidst the tree line, spanning the brook that separates Raventree Village & the Arbor District.");
            Arbor.SetAreaID("Arbor");
            Arbor.SetDescription("The area above town that features Unicorn Ranch, the Pointy Hat Club Lodge, the Mayor's House, & the Festival Grounds.");

            Arbor.SetBuildings(UnicornRanch, Lodge, MayorManse, FestivalGrounds);

            UnicornRanch.SetAreaID("Unicorn Ranch");
            UnicornRanch.SetOpen("close");
            //UnicornRanch.Operational(hour);
            //UnicornRanch.HoursOfOperation(9, 17);

            FestivalGrounds.SetAreaID("Arbor");
            FestivalGrounds.SetDescription("Ah, the faire grounds where holiday festivals & wizard tourneys are held... not to mention magical beasts best in show!");
            //FestivalGrounds.Operational(hour);
            //FestivalGrounds.HoursOfOperation(9, 17);
        }

        public void Initiate()
        {
            if (SetUp == true)
            {
                BuildWorld();
                currentArea = Homestead;
            }
            SetUp = false;
        }

        public void BuildWorld()
        {
            SetUpHome();
            SetUpCrossTrail();
            SetUpRaventreeVillage();
            SetUpArbor();
        }

        public void UpdateDisplay()
        {
            Console.Clear();
            Console.WriteLine($"Day {day} of Month {month}");
            Console.WriteLine($"{timeSym} {clock}");
            Console.WriteLine($"{currentSky} {currentWeather}");
            Console.WriteLine();
            Console.WriteLine($"Current Location: {currentArea.GetAreaID()}");
            Console.WriteLine($"{currentArea.GetDescription()}");
            Console.WriteLine();
            Console.WriteLine($"{currentPlayerStatus}");
            Console.WriteLine($"{thoughts} {player.GetReaction()}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }

        private string UserChoice()
        {
            bool ValidInput = false;

            //ToTheBottom();

            Console.Write("What would you like to do:? ");

            string _UserChoice = null;

            while (ValidInput == false)
            {
                string Input = Console.ReadLine();
                if (Input == "1" || Input == "2" || Input == "3" || Input == "4" || Input == "5" || Input == "6" || Input == "7" || Input == "8" || Input == "9")
                {
                    ValidInput = true;
                    _UserChoice = Input;
                }
                else
                {
                    Console.Write(" Invalid input! ");

                }
            }

            return _UserChoice;
        }

        //OPTIONS METHODS
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
        //string HomeOptions = "Please Choose: '1' Enter your home, '2' Enter your garden, '3' Enter your corral, '4' Enter woods, '5' Refresh";
        //string HomeSteadOptions = "Please Choose: '1' Go to bed, '2' Exit home, '3' Refresh";
        
        //string CorralOptions = "Please Choose: '1' View corral, '2' Stable new stock, '3' Take an animal with you, '4' Exit corral, '5' Refresh";
        //string WellOptions;
        public void OptionsHome()
        {
            string Input = UserChoice();
        }
        public void OptionsHomestead()
        {
            string Input = UserChoice();
        }
        public void OptionsGarden()
        {
            //string GardenOptions = "Please Choose: '1' Water your crops, '2' Plant a seed, '3' Harvest a crop, '4' Exit garden, '5' Refresh";
            Console.WriteLine(GardenOptions);
            string Input = UserChoice();
            if (Input == "1")
            {
                HomeGarden.WaterPlots();
                player.SpillCanteen();
                Action();

            } else if (Input == "2")
            {
                HomeGarden.Plant(player.GetSeedBag());
                player.SetSeedBag(null);
                Action();

            } else if (Input == "3")
            {
                Console.WriteLine(GardenTertiaryOptions);
                string SecondInput = UserChoice();

                Plantable CropToHarvest = HomeGarden.SelectCrop(SecondInput);
                player.PutInBag(CropToHarvest);
                Action();

            }
            else if (Input == "4")
            {
                ExitBuilding();
                Action();

            } else if (Input == "5")
            {
                Console.WriteLine(RefreshOptions);
                string RefreshInput = UserChoice();
                if(RefreshInput == "1")
                {
                    Console.WriteLine(WhichItemToEat);
                    string WhatToEat = UserChoice();
                    Item SelectedSnack = player.SelectItem(WhatToEat);

                    player.Eat(SelectedSnack);
                    Action();
                } else if (RefreshInput == "2")
                {
                    player.SipCanteen();
                    Action();
                } else if (RefreshInput == "3")
                {
                    Action();
                }
            }else
            {
                Console.Write(" Invalid Input! ");
            }

        }
        public void OptionsCorral()
        {
            string Input = UserChoice();
        }
        public void OptionsCrossTrail()
        {
            string Input = UserChoice();
        }
        public void OptionsWilderness()
        {
            string Input = UserChoice();
        }
        public void OptionsBlackwingStreet()
        {
            string Input = UserChoice();
        }
        public void OptionsMainStreet()
        {
            string Input = UserChoice();
        }
        public void OptionsNightGardenLane()
        {
            string Input = UserChoice();
        }
        public void OptionsApocathery()
        {
            string Input = UserChoice();
            Apocathery.GetWare1().GetName();
        }
        public void OptionsFaeRiverBridge()
        {
            string Input = UserChoice();
        }
        public void OptionsArbor()
        {
            string Input = UserChoice();
        }
        public void OptionsUnicornRanch()
        {
            string Input = UserChoice();
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

            player.Depletion();
            player.UpdateStatus();
            currentPlayerStatus = player.GetStatus();
            CheckHealth();
        }

        //CALENDAR METHODS
        void NewDay()
        {
            player.WakeUp();
            day++;
            SetWeather();
            SetSky();

            if (day == 32)
            {
                NewMonth();
            }

            HomeGarden.NextDay();

            if(raining == true)
            {
                HomeGarden.RainDay();
            }
            //HomeCorral.NextDay();
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

        //PLAYER METHODS
        public void CheckHealth()
        {
            if(player.GetPassedOut() == true)
            {
                GoToBed();
                hour++;
            }
            if(player.GetPerished() == true)
            {
                EndGame();
            }
        }

        public void GoToBed()
        {
            player.Sleep();
            currentArea = Homestead;
            player.UpdateStatus();
            NewDay();
            minutes = 0;
            hour = 6;
            SetClock();
        }

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
            //Console.WriteLine(GardenSecondaryOptions);
            //string SecondInput = UserChoice();

            //Item SeedToPlant = player.SelectItem(SecondInput);



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
