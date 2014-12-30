
namespace Spike.StubData.Builders
{
    using System;
    using Contracts.Authors;
    using Contracts.Authors.Requests;

    public class AuthorBuilder : Author
    {
        public AuthorBuilder()
        {
            this.Id = Guid.NewGuid();
        }

        public AuthorBuilder(Guid authorId)
        {
            this.Id = authorId;
        }
        
        public AuthorBuilder CliveCustler()
        {
            this.BirthDay = new DateTime(1931, 7, 15);
            this.Name = "Clive";
            this.Surname = "Cussler";
            
            return this;
        }

        public AuthorBuilder WilburSmith()
        {
            this.BirthDay = new DateTime(1933, 1, 9);
            this.Name = "Wilbur";
            this.Surname = "Smith";

            return this;
        }

        public Author Build()
        {
            return new Author
            {
                Id = this.Id,
                Name = this.Name,
                Surname = this.Surname,
                BirthDay = this.BirthDay
            };
        }

        public AddAuthorRequest BuildAddAuthorRequest()
        {
            return new AddAuthorRequest
            {
                BirthDay = this.BirthDay,
                Name = this.Name,
                Surname = this.Surname
            };
        }
    }
}
