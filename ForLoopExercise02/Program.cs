using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopExercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum = sum + i;
                Console.Write(" " + i);
            }
            Console.Write("\nThe Sum is: " + sum);
            Console.ReadLine();
        }
    }
}
