// BookService.cs
using System.Collections.Generic;
using LibraryManagement.Models;

namespace LibraryManagement.Services
{
    public class BookService
    {
        private readonly List<Book> _books;

        public BookService()
        {
            _books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        public List<Book> GetAllBooks()
        {
            return _books;
        }
    }
}