using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopExercise06
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, terms, sum = 0 , formula;

            Console.Write("Input number of terms : ");
            terms = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nThe odd numbers are :");
            for (i = 1; i <= terms; i++)
            {
                formula = 2 * i - 1;
                Console.Write(" " + formula);
                sum += 2 * i - 1;
            }
            Console.Write("\nThe Sum of odd Natural Number upto " + terms + " terms : "+ sum);
            Console.ReadLine();
        }
    }
}
