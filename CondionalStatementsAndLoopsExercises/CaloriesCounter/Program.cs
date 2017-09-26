using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int cheeseCalories = 0;
            int tomatoSauceCalories = 0;
            int salamiCalories = 0;
            int pepperCalories = 0;

            string tomatoSauce = "tomato sauce";
            string cheese = "cheese";
            string pepper = "pepper";
            string salami = "salami";

            for (int i = 1; i <= number; i++)
            {
                string ingredient = Console.ReadLine().ToLower();
                if (ingredient == cheese)
                {
                    cheeseCalories += 500;
                }
                else if (ingredient == tomatoSauce)
                {
                    tomatoSauceCalories += 150;
                }
                else if (ingredient == salami)
                {
                    salamiCalories += 600;
                }
                else if (ingredient == pepper)
                {
                    pepperCalories += 50;
                }
            }
            int totalCalories = cheeseCalories + tomatoSauceCalories +
                                pepperCalories + salamiCalories;

            Console.WriteLine($"Total calories: {totalCalories}");
        }

    }
}
