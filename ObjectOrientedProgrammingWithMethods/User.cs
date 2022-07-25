using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingWithMethods
{
    class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public void GetUser()
        {
            FirstName = "Francisco";
            LastName = "Cebu";
            Age = 31;
        }

    }
}
