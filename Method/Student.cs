using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Student
    {
        /*
        // Candidate method/action of a class student
        * Register
        * Enroll
        * Drop
        */
        public int studentNumber { get; set; }
        public int studentFullname { get; set; }

        // Method
        // Component of method
        // access modifier (public , private, protected)
        // return type / datatype
        // name

        // different implementation 

        // 1. A method that accepts nothing, returns nothing..
        public void Enroll()
        {

        }

        // 2. A method that accepts nothing, but returns something..
        public double Drop()
        {
            double balance = 200;
            return balance;
        }

        // 3. A method that accepts something, but returns nothing..

        /*
        public void Tuition(int prelim,int midterm, int finals)
        {
            int totalTuition = prelim + midterm + finals;
            Console.WriteLine("Tuition: " + totalTuition);
            Console.ReadLine();
        }
        */

        // 4. A method that accepts something, but returns something..
        public int Tuition(int prelim, int midterm, int finals)
        {
            int totalTuition = prelim + midterm + finals;
            return totalTuition;
            
        }

    }
}
