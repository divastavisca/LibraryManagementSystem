using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreSystem.Contracts;

namespace CoreSystem
{
    public class LibraryManager : ILibraryManager
    {
        public string GetDetails(string bookId)
        {
            throw new NotImplementedException();
        }

        public bool IsAvailable(Book askedBook)
        {
            throw new NotImplementedException();
        }

        public bool IssueBook(string bookId)
        {
            throw new NotImplementedException();
        }

        public void Return(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
