using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalExercise05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the age of the candidate : ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.Write("Congratulation! You are eligible for casting your vote.");
            }
            else
            {
                Console.Write("You are not eligible for casting your vote.");
            }
            Console.ReadLine();
        }
    }
}
