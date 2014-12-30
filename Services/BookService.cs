
using System.Linq;
using Spike.Services.Factories;
using Spike.StubData.DatabaseStub;

namespace Spike.Services
{
    using System;
    using System.Collections.Generic;
    using Contracts.Books;
    using Contracts.Books.Requests;
    using Contracts.Services;

    public class BookService : IBookService
    {
        public Book AddBook(AddBookRequest request)
        {
            var service = ServiceFactory.CreateAuthorService();
            var author = service.GetAuthorById(request.AuthorId);

            if (author == null)
            {
                throw new Exception("Author not found");
            }

            var book = new Book
            {
                Id = Guid.NewGuid(),
                Title = request.Title,
                Author = author,
                ReleaseDate = request.ReleaseDate
            };

            return Database.AddBook(book);
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return Database.Books;
        }

        public Book GetBookById(Guid bookId)
        {
            var book = Database.Books.FirstOrDefault(b => b.Id == bookId);

            return book;
        }
    }
}
