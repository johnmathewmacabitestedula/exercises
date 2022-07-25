using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingWithMethods
{
    class UserManagement : User
    {
        public void Add()
        {
            User user = new User();
            user.GetUser();
            Console.WriteLine("New Record Inserted: " + user.FirstName + " " + user.LastName + " " +user.Age + " years old");
            Console.ReadLine();
        }
        public void EditUser(string FirstName = "John Mathew",string LastName = "Estedula", int Age = 22)
        {
            Console.WriteLine("Record Updated: " + FirstName + " " + LastName + " " + Age + " years old");
            Console.ReadLine();
        }
        
    }
}