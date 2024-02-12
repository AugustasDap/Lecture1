using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level_2._2_Class_Methods
{
    internal class Library
    {
        public Library()
        {
            Books = new List<string>();      //konstruktorius       
        }

        public List<string> Books { get; set; }  //property


        //methos to add book
        public void AddBook(string bookTitle)
        {
            Books.Add(bookTitle);
        }


        //method to remove book
        public void RemoveBook(string bookTitle)
        {
            Books.Remove(bookTitle);
        }


        //method to print books
        public void DisplayBooks()
        {
            foreach (var book in Books)
            {
                Console.WriteLine(book);
            }
        }
    }
}
