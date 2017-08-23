using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreSystem
{
    public class BookIssueDetails
    {
        public Book ConcernedBook { get; private set; }
        public string PersonId { get; private set; }

        public BookIssueDetails(Book bookIssued,string personId)
        {
            ConcernedBook = bookIssued;
            PersonId = personId;
        }
    }
}
