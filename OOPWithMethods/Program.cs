using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPWithMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Applicant applicant = new Applicant();

            applicant.Name(); // return string
            applicant.Number(); // return int
            applicant.NameAndNumber(applicant.applicantFullname , applicant.applicantNumber); // return void

            ReturnClassUsingMethod.Hello(applicant.applicantFullname); // return class
        }
    }
}
