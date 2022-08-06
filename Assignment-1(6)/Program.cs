using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStructure
{
    class Program
    {
        struct Books
        {
            public enum bookType
            {
                Magazine,
                Novel,
                ReferenceBook,
                Miscellaneous
            }

            public string Title { get; set; }
            public int Price { get; set; }
            public int BookId { get; set; }
            public string BookType { get; set; }

        }
        class BookStructure
        {
            public static void Main()
            {
                Books bo = new Books();

                Console.Write("Enter Book Id :");
                bo.BookId = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Book Title:");
                bo.Title = (Console.ReadLine());

                Console.Write("Enter Book Price:");
                bo.Price = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Book Type:");
                bo.BookType = Console.ReadLine();


                Console.WriteLine("------------");
                Console.WriteLine("------------");
                Console.WriteLine(" Book ID :" + bo.BookId);
                Console.WriteLine(" Book Title:" + bo.Title);
                Console.WriteLine(" Book Price:" + bo.Price);
                Console.WriteLine(" Book BookType:" + bo.BookType);
            }
        }
    }
}
