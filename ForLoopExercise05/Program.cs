using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopExercise05
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int num, i, j;

            Console.Write("Input upto the table number starting from 1: ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Multiplication table from 1 to " + num);

            for (i = 1; i <= 10; i++)
            {
                for (j = 1; j <= num; j++)
                {
                    if (j <= num - 1) { 
                        Console.Write("{0}x{1} = {2}, ", j, i, i * j);
                        

                    }
                    else { 
                        Console.Write("{0}x{1} = {2}", j, i, i * j);
                    }

                }
                Console.Write("\n");
                Console.ReadLine();
            }
        }
    }
}
