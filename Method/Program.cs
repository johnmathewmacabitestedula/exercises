using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Student freshmen = new Student();
            freshmen.Enroll(); // calling a method
            //Console.WriteLine("Balance of drop students: " + freshmen.Drop());
            //Console.ReadLine();
            //freshmen.Tuition(200, 600, 800);
            Console.WriteLine("Tuition: " + freshmen.Tuition(200,600,800));
            Console.ReadLine();
        }
    }
}
