using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreSystem.Contracts
{
    public interface ILibraryManager
    {
        bool IsAvailable(Book askedBook);
        string GetDetails(string bookId);
        bool IssueBook(string bookId);
        void Return(Book book);
    }
}
