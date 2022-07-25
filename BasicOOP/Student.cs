using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOP
{
    class Student : Person
    {

        // properties
        public string studentNo { get; set; }
        public string section { get; set; }
        public double grade { get; set; }

        //methods
        public void enroll()
        {
            //todo
            //accept info
            //and save it to database
            Console.WriteLine("Ok Enroll lang");
            
        }
        public void enroll(string name,string studentnumber)
        {
            Console.WriteLine("Enrolling " + name + " with a student no. " + studentnumber);
            Console.ReadLine();
        }

        public void payTuition()
        {
            //todo
            //promp accept payment
            //save payment.
            Console.WriteLine("Magbayad kana lods");
        }
        public void payTuition(double payment)
        {
            Console.WriteLine("Payment " + payment);
            Console.ReadLine();
        }

    }
}
