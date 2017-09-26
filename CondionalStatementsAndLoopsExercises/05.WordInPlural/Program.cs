using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            string noun = Console.ReadLine();

            if (noun.EndsWith("y"))
            {
                noun = noun.Remove(noun.Length - 1); // noun.Replace but this will replace every character wanted to be replaced
                noun += "ies";
                Console.WriteLine(noun);
            }
            // o, ch, s, sh, x or z
            else if (noun.EndsWith("o") || noun.EndsWith("s") || noun.EndsWith("ch") || noun.EndsWith("sh")
                     || noun.EndsWith("x") || noun.EndsWith("z"))
            {
                noun += "es";
                Console.WriteLine(noun);
            }
            else
            // all other cases
            {
                noun += "s";
                Console.WriteLine(noun);
            }
        }
    }
}
