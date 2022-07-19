using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input First number: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input Second number: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input Third number: ");
            int z = Convert.ToInt32(Console.ReadLine());

            int a = (x + y) * z;
            int b = x * y + y * z;

            Console.WriteLine("Result of specified numbers " + x + "," + y + " and " + z + ", " + "(x + y).z is " + a + " and x.y + y.z is " + b);
            Console.ReadLine();

        }
    }
}
