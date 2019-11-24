using System;

namespace Zoo
{
    class Program
    {
        private Bear bear = new Bear();
        private Monkey monkey = new Monkey();
        public string getUserInput() {
            Console.WriteLine("================");
            Console.WriteLine("Zoo Menu Planner");
            Console.WriteLine("================");
            Console.WriteLine("1. Monkey");
            Console.WriteLine("2. Bear");
            Console.WriteLine("3. Quit");
            Console.Write("Selection: \n");
            string input = Console.ReadLine();
            if (input == "1") {
                this.monkey.GetMonkey();
            }
            else if (input == "2") {
                this.bear.GetBear();
            }
            else if (input == "3") {
                Console.WriteLine("To exit, press \"3\" + ENTER again. \n");
            }
            else {
                Console.WriteLine("Invalid input!");
            }
            return input;
        }
        static void Main(string[] args) {
            Program program = new Program();
            Console.WriteLine("Press ENTER to launch Zoo Meal Planner...");
            while(Console.ReadLine() != "3") {
                program.getUserInput();
            }
        }
    }
}





