using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleOOP
{
    class BookInformation : Borrower
    {
        public string name;
        public string BookName { get; set; }
        public string BookGenre { get; set; }
        public int BookNumber { get; set; }
        public string BookAuthor { get; set; }
        
        public void BorrowBook()
        {
            Console.Write("\n");
            Console.WriteLine("BORROWER NAME AND BOOK INFORMATION ");
            Console.Write("Hello " + name.ToUpper());
            Console.Write(" the book you borrow is " + BookName.ToUpper());
            Console.Write(" and the book number are " + BookNumber);
            Console.WriteLine(" this book is wrote by " + BookAuthor.ToUpper());
            Console.Write("\n");
            Console.WriteLine("Thank you for borrowing books Please return it after you read it");
            Console.ReadLine();
        }

        public void ReturnBook()
        {
            Console.Write("\n");
            Console.WriteLine("Thank you for returning our books");
        }
    }
}

