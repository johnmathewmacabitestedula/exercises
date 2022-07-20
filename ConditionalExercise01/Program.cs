using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalExercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input 1st number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input 2nd number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2)
            {
                Console.Write(num1 + " and " +num2 + " is equal");
            }
            else
            {
                Console.Write(num1 + " and " + num2 + " is not equal");
            }
            Console.ReadLine();
        }
    }
}
