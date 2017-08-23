using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoreSystem;
using CoreSystem.Contracts;

namespace LibraryManagementSystemFixture
{
    /// <summary>
    /// Summary description for Book_Manager_Tests
    /// </summary>
    [TestClass]
    public class Book_Manager_Tests
    {
        Library library;
        Book book;
        BookManager bookManager;
        public Book_Manager_Tests()
        {
            library = new Library();
            book = new Book
                (
                    "1",
                    "A song of Ice & Fire",
                    "xyz",
                    new List<PersonName>()
                    {
                        {
                            new PersonName("abc",null,"asdfas")
                        },
                    },
                    Genre.SuspenceFiction
                );
            library.AddBook(book);
            bookManager = new BookManager(library);
        }
        
        [TestMethod]
        public void Issuing_a_book_should_reflect_changes_in_library()
        {
            string id;
            bookManager.GetBookIdFromTitle("A song of Ice & Fire", out id);
            Book issuedBook= bookManager.IssueBookById(id);
            Assert.IsFalse(library.IsPresent(issuedBook));
        }
    }
}
