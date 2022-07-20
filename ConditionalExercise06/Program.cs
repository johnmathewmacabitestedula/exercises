using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionExercise06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the height of the person (in Centimeter): ");
            int height = Convert.ToInt32(Console.ReadLine());

            if (height <= 135.0) 
            {
                Console.Write("The person is Dwarf.");
            }
            else
            {
                Console.Write("The person is Tall.");
            }
            Console.ReadLine();
        }
    }
}
