
namespace Spike.StubData.DatabaseStub
{
    using System.Collections.Generic;
    using Contracts.Authors;
    using Contracts.Books;

    public static class Database
    {
        public static IList<Author> Authors = new List<Author>();
        public static IList<Book> Books = new List<Book>();

        public static Author AddAuthor(Author author)
        {
            Authors.Add(author);

            return author;
        }

        public static Book AddBook(Book book)
        {
            Books.Add(book);

            return book;
        }
    }
}
