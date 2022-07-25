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
            User user = new User();

            UserManagement userManagement = new UserManagement();
            Console.Write("Enter Firstname: ");
            user.firstName = Console.ReadLine();

            Console.Write("Enter Lastname: ");
            user.lastName = Console.ReadLine();

            Console.Write("Enter Age: ");
            user.Age = Convert.ToInt32(Console.ReadLine());

            userManagement.Add(user.firstName, user.lastName, user.Age);

            userManagement.Edit(user.firstName, user.lastName, user.Age);

            Console.WriteLine(userManagement.GetUser().firstName + " " + userManagement.GetUser().lastName + " " + userManagement.GetUser().Age);
            Console.ReadLine();
        }
    }
}
