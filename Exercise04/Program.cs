using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = -1 + 4 * 6, 
                num2 = (35 + 5) % 7, 
                num3 = 14 + -4 * 6 / 11, 
                num4 = 2 + 15 / 6 * 1 - 7 % 2;

            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            Console.WriteLine(num4);
            Console.ReadLine();
        }
    }
}
