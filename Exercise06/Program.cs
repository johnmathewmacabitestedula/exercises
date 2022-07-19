using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the first number to multiply: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the second number to multiply: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the third number to multiply: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1 + " x " + num2 + " x " + num3 + " = " + num1 * num2 * num3);
            Console.ReadLine();
        }
    }
}
