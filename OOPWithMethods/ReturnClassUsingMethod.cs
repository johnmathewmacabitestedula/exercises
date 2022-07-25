using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPWithMethods
{
    class ReturnClassUsingMethod : Applicant
    {
        public static void Hello(string name)
        {

            Console.WriteLine("Thank you " + name);
            Console.Read();
        }
    }
}
