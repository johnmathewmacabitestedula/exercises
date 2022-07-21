using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopExercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, sum = 0, value;

            Console.Write("Test Data: ");
            value = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The first " + value + " natural number is: ");

            for (i = 1; i <= value; i++)
            {
                Console.Write(" " + i);
                sum = sum + i;
            }
            Console.Write("\nThe sum of natural number upto " + value + " terms: " + sum);
            Console.ReadLine();
        }
    }
}
