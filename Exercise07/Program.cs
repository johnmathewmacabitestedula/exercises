using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int add = num1 + num2, 
                sub = num1 - num2, 
                multi = num1 * num2, 
                div = num1 / num2, 
                mod = num1 % num2;

            Console.WriteLine(num1 + " + " + num2 + " = " + add);
            Console.WriteLine(num1 + " - " + num2 + " = " + sub);
            Console.WriteLine(num1 + " x " + num2 + " = " + multi);
            Console.WriteLine(num1 + " / " + num2 + " = " + div);
            Console.WriteLine(num1 + " mod " + num2 + " = "+ mod);

            Console.ReadLine();
        }
    }
}
