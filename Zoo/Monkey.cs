using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Monkey : Mammal
    {
        const double SQUIR_SERVE_WEIGHT_RATIO = 0.006;
        const double HOWL_SERVE_WEIGHT_RATIO = 0.007;
        const double COLO_SERVE_WEIGHT_RATIO = 0.008;
        public void GetMonkey() {
            Console.WriteLine("Species");
            Console.WriteLine("----------");
            Console.WriteLine("1. Squirrel");
            Console.WriteLine("2. Howler");
            Console.WriteLine("3. Colobus");
            Console.WriteLine("Selection: \n");
            string input = Console.ReadLine();
            string feedTime = "Feed at 9AM, 12PM, and 5PM.";
            string food = "fresh fruit, vegetables, nuts, insects, berries.";
            string mammalType = "Monkey";
            string species = "";
            if (input == "1") {
                species = "Squirrel";
                double servingToWeightRatio = SQUIR_SERVE_WEIGHT_RATIO;
                double mammalWeight = base.GetMammalWeight();
                base.GetMammalMeal(mammalType, species, mammalWeight, servingToWeightRatio, food, feedTime);
            }
            else if (input == "2") {
                species = "Howler";
                double servingToWeightRatio = HOWL_SERVE_WEIGHT_RATIO;
                double mammalWeight = base.GetMammalWeight();
                base.GetMammalMeal(mammalType, species, mammalWeight, servingToWeightRatio, food, feedTime);
            }
            else if (input == "3") {
                species = "Colobus";
                double servingToWeightRatio = COLO_SERVE_WEIGHT_RATIO;
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

