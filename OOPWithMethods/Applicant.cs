using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPWithMethods
{
    class Applicant
    {
        public string applicantFullname { get; set; }
        public int applicantNumber { get; set; }

        public string Name()
        {
            Console.Write("Applicant Name: ");
            applicantFullname = Console.ReadLine();
            return applicantFullname;
        }

        public int Number()
        {
            Console.Write("Applicant Number: ");
            applicantNumber = Convert.ToInt32(Console.ReadLine());
            return applicantNumber;
        }
        public void NameAndNumber(string name, int number)
        {

            Console.WriteLine("Your Name is: " + name + " and your number is: " + number);
            Console.ReadLine();
        }
    }
}
