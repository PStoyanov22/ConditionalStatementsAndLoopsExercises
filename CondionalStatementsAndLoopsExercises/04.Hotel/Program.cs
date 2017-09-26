using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine().ToLower();
            int stay = int.Parse(Console.ReadLine());

            double studioPrice = 0.0;
            double doublePrice = 0.0;
            double suitePrice = 0.0;


            if (month == "may" || month == "october")
            {

                if (stay > 7)
                {
                    studioPrice = 50 - (0.05 * 50);
                    doublePrice = 65;
                    suitePrice = 75.00;
                }
                else
                {
                    studioPrice = 50;
                    doublePrice = 65;
                    suitePrice = 75.00;
                }


            }

            else if (month == "june" || month == "september")
            {

                if (stay > 14)
                {
                    studioPrice = 60;
                    doublePrice = 72 * 0.9;
                    suitePrice = 82;


                }
                else
                {
                    studioPrice = 60;
                    doublePrice = 72;
                    suitePrice = 82;
                }

            }

            else if (month == "july" || month == "august" || month == "december")
            {


                if (stay > 14)
                {
                    studioPrice = 68;
                    doublePrice = 77;
                    suitePrice = 89 * 0.85;
                }
                else
                {
                    studioPrice = 68;
                    doublePrice = 77;
                    suitePrice = 89;
                }


            }
            double totalStudioPrice = stay * studioPrice;
            if ((month == "september" || month == "october") && stay > 7)
            {
                totalStudioPrice = (stay - 1) * studioPrice;
            }
            double totalDoublePrice = stay * doublePrice;
            double totalSuitePrice = stay * suitePrice;

            Console.WriteLine($"Studio: {totalStudioPrice:f2} lv.");
            Console.WriteLine($"Double: {totalDoublePrice:f2} lv.");
            Console.WriteLine($"Suite: {totalSuitePrice:f2} lv.");

        }
    }
}
