using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalExercise09
{
    class Program
    {
        static void Main(string[] args)
        {    
            Console.Write("\nInput the marks obtained in Physics: ");
            int physics = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the marks obtained in Chemistry: ");
            int chemistry = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the marks obtained in Mathematics: ");
            int math = Convert.ToInt32(Console.ReadLine());
            int subjects = physics + chemistry + math;      
           
            if (math >= 65)
            {
                if (physics >= 55)
                {
                    if (chemistry >= 50)
                    {
                        if (subjects >= 180 || (math + physics) >= 140)
                        {
                            Console.Write("The  candidate is eligible for admission.\n");
                        }
                    }
                    else
                    {
                        Console.Write("The candidate is not eligible.\n\n");
                    }
                }
                else
                {
                    Console.Write("The candidate is not eligible.\n\n");
                }
            }
            else
            {
                Console.Write("The candidate is not eligible.\n\n");
            }
            Console.ReadLine();      
        }
    }
}
