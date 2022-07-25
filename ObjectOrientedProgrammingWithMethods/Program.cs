using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingWithMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            UserManagement usermanagement = new UserManagement();
            usermanagement.Add();
            usermanagement.EditUser();
        }
    }
}
