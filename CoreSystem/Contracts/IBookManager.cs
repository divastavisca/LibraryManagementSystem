using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreSystem.Contracts
{
    public interface IBookManager
    {
        bool IsIssued(string id);
        bool GetBookIdFromTitle(string bookTitle, out string id);
        Book IssueBookById(string id);
        void BookReturned(Book book);
    }
}
