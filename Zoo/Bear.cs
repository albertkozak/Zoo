using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Bear : Mammal
    {
        const double BB_SERVE_TO_WEIGHT_RATIO = 0.014;
        const double PB_SERVE_TO_WEIGHT_RATIO = 0.016;
        public void GetBear() {
            Console.WriteLine("Species");
            Console.WriteLine("--------");
            Console.WriteLine("1. Black");
            Console.WriteLine("2. Polar");
            Console.WriteLine("Selection: \n");
            string input = Console.ReadLine();
            string feedTime = " Feed at 9AM and 3PM";
            if (input == "1") {
                double servingToWeightRatio = BB_SERVE_TO_WEIGHT_RATIO;
                double mammalWeight = base.GetMammalWeight();
                base.GetMammalMeal(mammalWeight, servingToWeightRatio, "berries, green vegetation, flowers, fruits, fish", feedTime);
            }
            else if (input == "2") {
                double servingToWeightRatio = PB_SERVE_TO_WEIGHT_RATIO;
                double mammalWeight = base.GetMammalWeight();
                base.GetMammalMeal(mammalWeight, servingToWeightRatio, "berries, fish", feedTime);
            }
            else {
                Console.WriteLine("Invalid input!");
                this.GetBear();
            }
        }
    }
}
