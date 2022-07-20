using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionExercise07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the 1st number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the 2nd number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the 3rd number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());


            if (num1 > num2 && num1 > num3)
            {
                Console.Write("the 1st number is the greatest among three");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.Write("the 2nd number is the greatest among three");
            }
            else
            {
                Console.Write("the 3rd number is the greatest among three");
            }
            Console.ReadLine();
        }
    }
}
