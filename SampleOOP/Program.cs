using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            int choices1, choices2;
            Borrower borrower = new Borrower();
            BookInformation bookinformation = new BookInformation();

            Console.WriteLine("LIBRARY CONSOLE APP \n");

            Console.Write("DO YOU WANT TO GO TO LIBRARY? TYPE 1 IF YES TYPE 2 IF NO: ");

            choices1 = Convert.ToInt32(Console.ReadLine());

            if (choices1 == 1)
            {
                Console.Write("\n");
                Console.WriteLine("WELCOME TO JOHN MATHEW LIBRARY \n");

                Console.Write("ARE YOU HERE TO BORROW BOOKS OR TO RETURN BOOKS? TYPE 1 FOR BORROW TYPE 2 FOR RETURNING: ");
                choices2 = Convert.ToInt32(Console.ReadLine());

                if (choices2 == 1)
                {
                    Console.Write("\n");
                    Console.WriteLine("BORROWER INFORMATION \n");
                    Console.Write("NAME: ");
                    borrower.BorrowerName = Console.ReadLine();

                    Console.Write("AGE: ");
                    borrower.BorrowerAge = Convert.ToInt32(Console.ReadLine());

                    Console.Write("GENDER: ");
                    borrower.BorrowerGender = Console.ReadLine();

                    Console.Write("BIRTHDAY: ");
                    borrower.BorrowerBirthday = Console.ReadLine();

                    borrower.Borrow();
                }
                else if (choices2 == 2)
                {
                    bookinformation.ReturnBook();
                }
            } 
            else
            {
                Console.Write("\n");
                Console.WriteLine("IT'S OKEY IF YOU DONT WANT TO GO!!");
            }
            Console.ReadLine();
        }
    }
}
