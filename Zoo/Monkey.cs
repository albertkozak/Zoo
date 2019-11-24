using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Monkey : Mammal
    {
        const double SQUIRREL_SERVE_TO_WEIGHT_RATIO = 0.006;
        const double HOWLER_SERVE_TO_WEIGHT_RATIO = 0.007;
        const double COLOBUS_SERVE_TO_WEIGHT_RATIO = 0.008;
        public void GetMonkey() {
            Console.WriteLine("Species");
            Console.WriteLine("----------");
            Console.WriteLine("1. Squirrel");
            Console.WriteLine("2. Howler");
            Console.WriteLine("3. Colobus");
            Console.WriteLine("Selection: \n");
            string input = Console.ReadLine();
            string feedTime = "Feed at 9am, 12pm and 5pm";
            string food = "fresh fruit, vegetables, nuts, insects, berries";
            string mammalType = "Monkey";
            string species = "";
            if (input == "1") {
                species = "Squirrel";
                double servingToWeightRatio = SQUIRREL_SERVE_TO_WEIGHT_RATIO;
                double mammalWeight = base.GetMammalWeight();
                base.GetMammalMeal(mammalType, species, mammalWeight, servingToWeightRatio, food, feedTime);
            }
            else if (input == "2") {
                species = "Howler";
                double servingToWeightRatio = HOWLER_SERVE_TO_WEIGHT_RATIO;
                double mammalWeight = base.GetMammalWeight();
                base.GetMammalMeal(mammalType, species, mammalWeight, servingToWeightRatio, food, feedTime);
            }
            else if (input == "3") {
                species = "Colobus";
                double servingToWeightRatio = COLOBUS_SERVE_TO_WEIGHT_RATIO;
                double mammalWeight = base.GetMammalWeight();
                base.GetMammalMeal(mammalType, species, mammalWeight, servingToWeightRatio, food, feedTime);
            }
            else {
                Console.WriteLine("Invalid input!");
                this.GetMonkey();
            }
        }
    }
}

