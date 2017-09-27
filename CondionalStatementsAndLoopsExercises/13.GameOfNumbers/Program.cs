using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int magicalNumber = int.Parse(Console.ReadLine());

            int combinations = 0;


            for (int i = firstNumber; i <= secondNumber; i++)
            {
                for (int j = firstNumber; j <= secondNumber; j++)
                {


                    if (j + i == magicalNumber)
                    {
                        Console.WriteLine($"Number found! {j} + {i} = {magicalNumber}");
                        return;
                    }

                    combinations++;
                }

                    if (j + i == magicalNumber)
                    {
                        Console.WriteLine($"Number found! {j} + {i} = {magicalNumber}");
                        return;
                    }



         }
            Console.WriteLine($"{combinations} combinations - neither equals {magicalNumber}");
        }
    }
}
