using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopExercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, q = 1;
            for ( i = 0; i <= 4; i++)
            {
                for ( j = 0; j < i; j++)
                {
                    Console.Write(" "+ q++);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
