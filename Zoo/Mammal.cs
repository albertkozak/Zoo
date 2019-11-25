using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Mammal
    {
        double input = 0;
        public double GetMammalWeight() {
            double mammalWeight;
            Console.WriteLine("Weight in KG: \n");
            try {
                input = Convert.ToDouble(Console.ReadLine());
            }
            catch {
                Console.WriteLine("Invalid input for weight! \n");
                GetMammalWeight();
            }
            if (input > 0) {
                mammalWeight = input;
            }
            else {
                Console.WriteLine("Weight cannot be zero! \n");
                this.GetMammalWeight();
            }
            return Math.Round(input, 2);
        }

        public void GetMammalMeal(string mammalType, string species, double mammalWeight, double servingSizeRatio, string serving, string feedTime) {
            Console.WriteLine("\nMeal Recommendation");
            Console.WriteLine("----------------------");
            Console.WriteLine("Mammal Type:  " + mammalType);
            Console.WriteLine("Species:      " + species);
            Console.WriteLine("Weight:       " + mammalWeight + " KG");
            Console.WriteLine("Serving:      " + Math.Round((mammalWeight * servingSizeRatio),3) + " KG " + serving);
            Console.WriteLine("\nInstructions: Keep area secure at all times.\n");
            Console.WriteLine(feedTime);
        }
    }
}
