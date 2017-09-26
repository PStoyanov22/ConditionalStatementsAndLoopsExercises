using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            for (int row = 1; row <= num; row++)
            {
                for (int col = 0; col < row; col++)
                {
                    Console.Write(row + " ");
                                        
                }
                Console.WriteLine();
            }
        }
    }
}
