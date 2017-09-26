using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeighbourWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int PeshoDamage = int.Parse(Console.ReadLine());
            int goshoDamage = int.Parse(Console.ReadLine());

            string pesho = "Pesho";
            string gosho = "Gosho";

            string peshoAttack = "Roundhouse kick";
            string goshoAttack = "Thunderous fist";

            int turn = 1;

            int peshoHealth = 100;
            int goshoHealth = 100;

            while (peshoHealth > 0 && goshoHealth > 0)
            {
                

                if (turn % 2 != 0)
                {
                    goshoHealth -= PeshoDamage;
                    if (goshoHealth < 1)
                    {
                        Console.WriteLine($"{pesho} won in {turn}th round.");
                        continue;
                    }

                    Console.WriteLine($"{pesho} used {peshoAttack} and reduced {gosho} to {goshoHealth} health.");
                    
                }
                else if (turn % 2 == 0)
                {
                    peshoHealth -= goshoDamage;
                    if (peshoHealth < 1)
                    {
                        Console.WriteLine($"{gosho} won in {turn}th round.");
                        break;
                    }

                    Console.WriteLine($"{gosho} used {goshoAttack} and reduced {pesho} to {peshoHealth} health.");

                }
                if (turn % 3 == 0)
                {
                    peshoHealth += 10;
                    goshoHealth += 10;
                }



                turn++;
            }
        }
    }
}
