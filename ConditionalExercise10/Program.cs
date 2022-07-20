using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalExercise10
{
    class Program
    {
        static void Main(string[] args)
        {

            double roll, physics, chemistry, computer, mark, percentage;
            string name, division = "";

            Console.Write("Input the Roll Number of the student: ");
             roll = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the Name of the Student: ");
             name = Console.ReadLine();

            Console.Write("Input the marks obtained in Physics: ");
             physics = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the marks obtained in Chemistry: ");
             chemistry = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the marks obtained in Computer Application: ");
             computer = Convert.ToInt32(Console.ReadLine());

             mark = physics + chemistry + computer;
             percentage = mark/3.0;

            if (percentage >= 60)
            {
                division = "First";
            }
            if (percentage < 60 && percentage >= 48)
            {
                division = "Second";
            }

            Console.WriteLine("Roll No: " + roll);
            Console.WriteLine("Name of Student: " + name);
            Console.WriteLine("Marks in Physics: " + physics);
            Console.WriteLine("Marks in Chemistry: " + chemistry);
            Console.WriteLine("Marks in Computer Application: " + computer);
            Console.WriteLine("Total Marks = " + mark);
            Console.WriteLine("Percentage = " + percentage);
            Console.WriteLine("Division = " + division);
            Console.ReadLine();
        }
    }
}
