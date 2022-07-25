using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingWithMethods
{
    class UserManagement : User
    {
        public void Add(string firstname, string lastname, int age)
        {
            Console.WriteLine("New Record Inserted: " + firstname + " " + lastname + " " + age + " years old");
            Console.ReadLine();
        }
        public void Edit(string firstname, string lastname, int age)
        {
            Console.WriteLine("Record Updated: " + firstname + " " + lastname + " " + age + " years old");
            Console.ReadLine();
        }
        public User GetUser()
        {
            User user = new User();
            user.firstName = "Francisco";
            user.lastName = "Cebu";
            user.Age = 31;

            return user;
        }

       
    }
}