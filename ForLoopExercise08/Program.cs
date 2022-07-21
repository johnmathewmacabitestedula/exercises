using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopExercise08
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;

            for (i = 1; i <= 4; i++)

            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("" + j);

                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
