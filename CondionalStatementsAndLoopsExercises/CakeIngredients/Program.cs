using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingredient = Console.ReadLine();
            Console.WriteLine($"Adding ingredient {ingredient}.");
            int ingredientNumber = 1;

            while (ingredient != "Bake!")
            {
                ingredient = Console.ReadLine();
                if (ingredient == "Bake!")
                {
                    break;
                }
                Console.WriteLine($"Adding ingredient {ingredient}.");
                ingredientNumber++;
            }
            

            Console.WriteLine($"Preparing cake with {ingredientNumber} ingredients.");
        }
    }
}
