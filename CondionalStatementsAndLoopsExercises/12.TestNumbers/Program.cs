using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int limit = int.Parse(Console.ReadLine());

            int combinations = 0;
            int rotations = 0;

            for (int n = num1; n >= 1; n--)
            {
                for (int m = 1; m <= num2; m++)
                {                    
                    combinations++;
                    int sum1 = 3 * (n * m);
                    rotations += sum1;

                    if (rotations >= limit)
                    {
                        Console.WriteLine($"{combinations} combinations");
                        Console.WriteLine($"Sum: {rotations} >= {limit}");
                        return;
                    }                   

                    
                }
            }
            Console.WriteLine($"{combinations} combinations");
            Console.WriteLine($"Sum: {rotations}");
        }
    }
}
