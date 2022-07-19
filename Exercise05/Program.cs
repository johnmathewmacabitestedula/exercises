using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input First number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input Second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("After Swapping: ");

            Console.WriteLine("First Number: " + num2);
            Console.Write("Second Number: " + num1);

            Console.ReadLine();

        }
    }
}
