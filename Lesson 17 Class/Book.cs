using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_17_Class
{
    internal class Book
    {
        public Book(string bookTitle, string bookAuthor, int bookYear) : this(bookTitle, bookAuthor, bookYear, "Unknown")
        {

        }

        public Book(string bookTitle, string bookAuthor, int bookYear, string countryOfEdition)
        {
            Title = bookTitle;
            Author = bookAuthor;
            Year = bookYear;
            CountryOfEdition = countryOfEdition;
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }

        public string CountryOfEdition { get; set; }
    }

}

