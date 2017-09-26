using System;
namespace IntervalOfNumbers
{
    public class Program
    {
        public static void Main()
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            int greaterNumber = Math.Max(number1, number2);

            for (int i = Math.Min(number1, number2); i <= greaterNumber; i++)
            {
                Console.WriteLine(i);
            }



        }
    }
}
