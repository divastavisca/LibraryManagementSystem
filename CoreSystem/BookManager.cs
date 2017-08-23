using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreSystem.Contracts;

namespace CoreSystem
{
    public class BookManager : CoreSystem.Contracts.IBookManager
    {
        private Dictionary<string, IssueStatus> _bookLog;
        private List<Book> _books;
        private Library _library;

        public Book IssueBookById(string id)
        {
            if(_bookLog.ContainsKey(id)&&IsIssued(id)==false)
            {
                foreach (Book book in _books)
                    if (book.Id == id)
                    {
                        _bookLog[id] = IssueStatus.Issued;
                        _library.RemoveBook(book); //As book is issued book should be taken from library
                        return book;
                    }
                    else continue;
            }
            return Book.Empty;
        }

        public void BookReturned(Book book)
        {
            string id = book.Id;
            _bookLog[id] = IssueStatus.Available;
            _library.AddBook(book);
        }

        public bool GetBookIdFromTitle(string bookTitle, out string id)
        {
            foreach(Book book in _books)
            {
                if(book.Title==bookTitle)
                {
                    id = book.Id;
                    return true;
                }
            }
            id = string.Empty;
            return false;
        }

        public bool IsIssued(string id)
        {
            return (_bookLog.ContainsKey(id) && (_bookLog[id] == IssueStatus.Issued));
        }

        private void initializeLog()
        {
            _books = _library.GetAllBooks();
            _bookLog = new Dictionary<string, IssueStatus>();
            foreach(Book book in _books)
            {
                _bookLog.Add(book.Id, IssueStatus.Available);
            }
        }

        public BookManager()
        {
            _library = new Library();
            initializeLog();
        }
    }
}
