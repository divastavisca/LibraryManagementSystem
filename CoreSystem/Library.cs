using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreSystem
{
    public class Library
    {
        private List<Book> _books;

        public bool IsPresent(Book book)
        {
            return _books.Contains(book);
        }

        public List<Book> GetAllBooks()
        {
            return _books;
        }

        /// <summary>
        /// When a book is returned it should be added to the library
        /// </summary>
        /// <param name="book"></param>
        public void AddBook(Book book)
        {
            _books.Add(book);
        }


        /// <summary>
        /// When a book is issued it should be removed from the library
        /// </summary>
        /// <param name="book"></param>
        public void RemoveBook(Book book)
        {
            if(IsPresent(book))
                _books.Remove(book);
        }

        public Library()
        {
            _books = new List<Book>();
        }
    }
}
