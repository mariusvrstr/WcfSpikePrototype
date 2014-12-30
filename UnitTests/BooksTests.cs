
namespace Spike.UnitTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Linq;
    using StubData.Builders;
    using StubData.ObjectMother;
    using Factories;

    [TestClass]
    public class BookTests
    {
        [TestInitialize]
        public void InitializeTest()
        {
            ObjectMother.Initialize();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            ObjectMother.Reset();
        }

        [TestMethod]
        public void TestAddingValidBook()
        {
            var service = ServiceFactory.CreateBookService();

            var request = new BookBuilder().Cyclops(ObjectMother.Instance.Authors.CliveCusler).BuildAddBookRequest();

            var response = service.AddBook(request);
            Assert.IsNotNull(response);

            var assertBook = new BookBuilder(response.Id).Cyclops(ObjectMother.Instance.Authors.CliveCusler).Build();
            Assert.AreEqual(assertBook, response);
        }

        [TestMethod]
        public void TestSearchExistingBookById()
        {
            var service = ServiceFactory.CreateBookService();
            var existingBookId = ObjectMother.Instance.Books.IncaGold.Id;

            var book = service.GetBookById(existingBookId);
            Assert.IsNotNull(book);

            var assertBook = new BookBuilder(existingBookId).IncaGold(ObjectMother.Instance.Authors.CliveCusler).Build();
            Assert.AreEqual(assertBook, book);
        }

        [TestMethod]
        public void GetAllExistingBooks()
        {
            var service = ServiceFactory.CreateBookService();

            var books = service.GetAllBooks();
            Assert.IsNotNull(books);

            Assert.IsTrue(books.Any());
        }
    }
}
