using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleOOP
{
    class Borrower
    {
        int choices3;

        public string BorrowerName { get; set; }
        public int BorrowerAge { get; set; }
        public string BorrowerGender { get; set; }
        public string BorrowerBirthday { get; set; }

        public void Borrow()
        {
            Console.Write("\n");
            Console.Write("ARE YOU SURE YOU WANT TO BORROW BOOKS? TYPE 1 IF YES TYPE 2 IF NO: ");
            choices3 = Convert.ToInt32(Console.ReadLine());

                if (choices3 == 1)
                {
                    Console.Write("\n");
                    Console.WriteLine("BOOK INFORMATION \n");

                    BookInformation bookinformation = new BookInformation();
                    
                    bookinformation.name = BorrowerName;
                    Console.Write("BOOK NAME: ");
                    bookinformation.BookName = Console.ReadLine();

                    Console.Write("GENRE: ");
                    bookinformation.BookGenre = Console.ReadLine();

                    Console.Write("BOOK NUMBER: ");
                    bookinformation.BookNumber = Convert.ToInt32(Console.ReadLine());

                    Console.Write("BOOK AUTHOR: ");
                    bookinformation.BookAuthor = Console.ReadLine();

                    bookinformation.BorrowBook();

                }
                else
                {
                    CancelBorrow();
                }
            Console.ReadLine();
        }

        public void CancelBorrow()
        {
            Console.Write("\n");
            Console.WriteLine("OHH I THOUGHT YOU'RE GONNA BORROW BOOKS HAHA...");
        }
    }

}
