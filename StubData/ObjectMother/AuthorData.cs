
namespace Spike.StubData.ObjectMother
{
    using Contracts.Authors;
    using Builders;

    public class AuthorData
    {
        public AuthorData Init()
        {
            this.CliveCusler = DatabaseStub.Database.AddAuthor(
                new AuthorBuilder().CliveCustler().Build());

            return this;
        }

        public Author CliveCusler { get; set; }
    }
}
