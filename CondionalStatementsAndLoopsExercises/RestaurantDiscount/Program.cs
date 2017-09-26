using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            string hall;
            double hallPrice;

            if (groupSize > 0 && groupSize <= 50)
            {
                hall = "Small Hall";
                hallPrice = 2500;
                if (package == "Normal")
                {
                    hallPrice = 3000 * 0.95;
                }
                else if (package == "Gold")
                {
                    hallPrice = 3250 * 0.9;
                }
                else if (package == "Platinum")
                {
                    hallPrice = 3500 * 0.85;
                }
                Console.WriteLine($"We can offer you the {hall}");
                Console.WriteLine($"The price per person is {(hallPrice / groupSize):f2}$");
                
            }
            else if (groupSize > 50 && groupSize <= 100)
            {
                hall = "Terrace";
                hallPrice = 5000;
                if (package == "Normal")
                {
                    hallPrice = 5500 * 0.95;
                }
                else if (package == "Gold")
                {
                    hallPrice = 5750 * 0.9;
                }
                else if (package == "Platinum")
                {
                    hallPrice = 6000 * 0.85;
                }
                Console.WriteLine($"We can offer you the {hall}");
                Console.WriteLine($"The price per person is {(hallPrice / groupSize):f2}$");
            }
            else if (groupSize > 100 && groupSize <= 120)
            {
                hall = "Great Hall";
                hallPrice = 7500;
                if (package == "Normal")
                {
                    hallPrice = 8000 * 0.95;
                }
                else if (package == "Gold")
                {
                    hallPrice = 8250 * 0.9;
                }
                else if (package == "Platinum")
                {
                    hallPrice = 9000 * 0.85;
                }
                Console.WriteLine($"We can offer you the {hall}");
                Console.WriteLine($"The price per person is {(hallPrice / groupSize):f2}$");
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}
