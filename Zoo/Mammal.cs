using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Mammal
    {
        public double GetMammalWeight() {
            double mammalWeight;
            Console.WriteLine("Weight in KG: \n");
            double input = 0;
            try {
                input = Convert.ToDouble(Console.ReadLine());
            }
            catch {
                Console.WriteLine("Invalid input for weight! \n");
                GetMammalWeight();
            }
            if (input < 0) {
                Console.WriteLine("Weight cannot be zero! \n");
                this.GetMammalWeight();
            }
            else {
                mammalWeight = input;
            }
            return input;
        }

        public void GetMammalMeal(double mammalWeight, double servingSizeRatio, string serving, string feedTime)
        {
            Console.WriteLine("\nMeal Recommendation");
            Console.WriteLine("-------------------");
            Console.WriteLine("Mammal Type: ");
            Console.WriteLine("Species: ");
            Console.WriteLine("Weight:     " + mammalWeight + " KG");
            Console.WriteLine("Serving:     " + mammalWeight * servingSizeRatio + " KG " + serving);
            Console.WriteLine("Instructions: Keep area secure at all times." + feedTime);
        }
    }
}
