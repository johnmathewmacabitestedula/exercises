﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise08
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} x {1} = {2}", num, 0, num * 0);

            Console.WriteLine("{0} x {1} = {2}", num, 1, num * 1);

            Console.WriteLine("{0} x {1} = {2}", num, 2, num * 2);


            Console.WriteLine("{0} x {1} = {2}", num, 3, num * 3);

            Console.WriteLine("{0} x {1} = {2}", num, 4, num * 4);

            Console.WriteLine("{0} x {1} = {2}", num, 5, num * 5);

            Console.WriteLine("{0} x {1} = {2}", num, 6, num * 6);

            Console.WriteLine("{0} x {1} = {2}", num, 7, num * 7);

            Console.WriteLine("{0} x {1} = {2}", num, 8, num * 8);

            Console.WriteLine("{0} x {1} = {2}", num, 9, num * 9);

            Console.WriteLine("{0} x {1} = {2}", num, 10, num * 10);

            Console.ReadLine();

        }
    }
}
