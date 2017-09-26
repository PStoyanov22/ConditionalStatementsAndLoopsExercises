using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseADrink2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int drinkQuantity = int.Parse(Console.ReadLine());

            double waterPrice = 0.7;
            double teaPrice = 1.20;
            double beerPrice = 1.70;
            double coffeePrice = 1.0;


            if (profession == "Athlete")
            {
                Console.WriteLine($"The {profession} has to pay {(drinkQuantity * waterPrice):f2}.");
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                Console.WriteLine($"The {profession} has to pay {(drinkQuantity * coffeePrice):f2}.");
            }
            else if (profession == "SoftUni Student")
            {
                Console.WriteLine($"The {profession} has to pay {(drinkQuantity * beerPrice):f2}.");
            }
            else
            {
                Console.WriteLine($"The {profession} has to pay {(drinkQuantity * teaPrice):f2}.");
            }
        }
    }
}
