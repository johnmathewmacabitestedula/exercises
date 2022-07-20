using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalExercise08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the value for X coordinate: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the value for Y coordinate: ");
            int y = Convert.ToInt32(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.Write("The coordinate point (" + x + "," + y + ")lies in the First quadrant");
            }
            else
            {
                Console.Write("I dont know this coordinate point");
            }
            Console.ReadLine();
        }
    }
}
