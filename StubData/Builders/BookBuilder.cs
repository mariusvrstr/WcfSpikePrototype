
namespace Spike.StubData.Builders
{
    using System;
    using Contracts.Books;
    using Contracts.Authors;
    using Contracts.Books.Requests;

    public class BookBuilder : Book
    {
        public BookBuilder()
        {
            this.Id = Guid.NewGuid();
        }

        public BookBuilder(Guid bookId)
        {
            this.Id = bookId;
        }

        public BookBuilder IncaGold(Author author)
        {
            this.Author = author;
            this.Title = "Inca Gold";
            this.ReleaseDate = new DateTime(1994);

            return this;
        }

        public BookBuilder Cyclops(Author author)
        {
            this.Author = author;
            this.Title = "Cyclops";
            this.ReleaseDate = new DateTime(1986);

            return this;
        }

        public BookBuilder Assegai(Author author)
        {
            this.Author = author;
            this.Title = "Assegai";
            this.ReleaseDate = new DateTime(2009);

            return this;
        }

        public BookBuilder Rage(Author author)
        {
            this.Author = author;
            this.Title = "Rage";
            this.ReleaseDate = new DateTime(1987);

            return this;
        }

        public Book Build()
        {
            return new Book
            {
                Id = this.Id,
                Author = this.Author,
                ReleaseDate = this.ReleaseDate,
                Title = this.Title
            };
        }

        public AddBookRequest BuildAddBookRequest()
        {
            return new AddBookRequest
            {
                AuthorId = this.Author.Id,
                ReleaseDate = this.ReleaseDate,
                Title = this.Title
            };
        }
    }
}
