
namespace Spike.StubData.ObjectMother
{
    using Builders;
    using Contracts.Books;

    public class BookData
    {
        public BookData Init()
        {
            this.IncaGold = DatabaseStub.Database.AddBook(
                new BookBuilder()
                    .IncaGold(ObjectMother.Instance.Authors.CliveCusler)
                    .Build());

            return this;
        }

        public Book IncaGold { get; set; }
    }
}
