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

        public Book GetBookById(string id)
        {
            if(_bookLog.ContainsKey(id))
            {
                foreach (Book book in _books)
                    if (book.Id == id)
                        return book;
                    else continue;
            }
            return null;
        }

        public bool GetBookIdFromTitle(string bookTitle, out string id)
        {
            throw new NotImplementedException();
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
