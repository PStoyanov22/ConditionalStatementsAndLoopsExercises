using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5DifferentNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
           


            int interval = Math.Abs(firstNum - secondNum);
            
            


           
            if (interval >= 5)
            {
                for (int firstNumber = firstNum; firstNumber <= (secondNum); firstNumber++)
                {
                    for (int secondNumber = firstNum; secondNumber <= secondNum; secondNumber++)
                    {
                        for (int thirdNumber = firstNum; thirdNumber <= secondNum; thirdNumber++)
                        {
                            for (int forthNumber = firstNum; forthNumber <= secondNum; forthNumber++)
                            {
                                for (int fifthNumber = firstNum; fifthNumber <= secondNum; fifthNumber++)
                                {
                                    if (firstNum <= firstNumber && firstNumber < secondNumber &&
                                        secondNumber < thirdNumber && thirdNumber < forthNumber &&
                                        forthNumber < fifthNumber && fifthNumber <= secondNum)
                                    {
                                        Console.WriteLine($"{firstNumber} {secondNumber} {thirdNumber} {forthNumber} {fifthNumber}");

                                    }                                   
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
