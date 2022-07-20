using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalExercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input an number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine(num + " is an even integer.");
            }
        
            else
            {
                Console.WriteLine(num + " is an odd integer.");
            }
            Console.ReadLine();
        }
    }
}
