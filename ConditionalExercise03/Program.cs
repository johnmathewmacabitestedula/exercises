using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalExercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input an number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine(num + " is a positive number.");
            }
            else
            {
                Console.WriteLine(num + " is a negative number.");
            }
            Console.ReadLine();
        }
    }
}
