
namespace Spike.Services
{
    using System;
    using System.Collections.Generic;
    using Contracts.Authors;
    using Contracts.Authors.Requests;
    using Contracts.Services;
    using System.Linq;
    using StubData.DatabaseStub;

    public class AuthorService : IAuthorService
    {
        public Author AddAuthor(AddAuthorRequest request)
        {
            var author = new Author()
            {
                Id = Guid.NewGuid(),
                BirthDay = request.BirthDay,
                Name = request.Name,
                Surname = request.Surname
            };

            var response = Database.AddAuthor(author);

            return response;
        }

        public IEnumerable<Author> GetAllAuthors()
        {
            return Database.Authors;
        }

        public Author GetAuthorById(Guid authorId)
        {
            var author = Database.Authors.FirstOrDefault(auth => auth.Id == authorId);

            return author;
        }
    }
}
