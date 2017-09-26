using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountTheIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 0;
            int count = 0;
            while (true)
            {
                string input = Console.ReadLine(); // Read string from console

                if (int.TryParse(input, out value))
                {
                    count++;
                }
                else
                {
                    Console.WriteLine(count);
                    break;
                }
            }           
            
        }
    }
}
