﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopExercise09
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("" + i);
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
