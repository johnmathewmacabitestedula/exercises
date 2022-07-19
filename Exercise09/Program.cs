using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input First number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input Second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input Third number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input Fourth number: ");
            int num4 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2 + num3 + num4;

            int average = sum / 4;

            Console.Write("Average is: " + average);
            Console.ReadLine();
        }
    }
}
