using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopExercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, i, mul;
            Console.Write("Input the number (Table to be calculated) : ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            for (i = 1; i <= 10; i++)
            {
                mul = num * i;
                Console.Write(num + " X " + i + " = " + mul + "\n");
            }
            Console.ReadLine();
        }
    }
}
