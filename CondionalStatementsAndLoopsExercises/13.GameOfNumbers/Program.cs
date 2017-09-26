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
            int lastCombination;

            for (int i = firstNumber; i <= secondNumber; i++)
            {
                for (int j = firstNumber; j <= secondNumber; j++)
                {
                    combinations++;

                    int biggestI = i;
                    biggestI++;
                    if (biggestI > j && ((biggestI + j) == magicalNumber))
                    {
                        Console.WriteLine($"Number found! {biggestI}+{j} = {magicalNumber}, {combinations}");
                    }
                    if (!(biggestI + j == magicalNumber))

                    {
                        Console.WriteLine($"Total combinations: {combinations} combinations – neither equals {magicalNumber}");
                    }



                }
                

            }
        }
    }
}