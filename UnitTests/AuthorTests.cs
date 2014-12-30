
using Spike.Contracts.Authors;

namespace Spike.UnitTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Linq;
    using StubData.Builders;
    using StubData.ObjectMother;
    using Factories;

    [TestClass]
    public class AuthorTests
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
        public void TestAddingValidAuthor()
        {
            var service = ServiceFactory.CreateAuthorService();
            var request = new AuthorBuilder().WilburSmith().BuildAddAuthorRequest();

            var response = service.AddAuthor(request);
            Assert.IsNotNull(response);

            var assertAuthor = new AuthorBuilder(response.Id).WilburSmith().Build();
            Assert.AreEqual(assertAuthor, response);
        }

        [TestMethod]
        public void TestSearchExistingAuthorById()
        {
            var service = ServiceFactory.CreateAuthorService();
            var existingAuthorId = ObjectMother.Instance.Authors.CliveCusler.Id;

            var author = service.GetAuthorById(existingAuthorId);
            Assert.IsNotNull(author);

            var assertAuthor = new AuthorBuilder(existingAuthorId).CliveCustler().Build();
            Assert.AreEqual(assertAuthor, author);
        }

        [TestMethod]
        public void GetAllExistingAuthors()
        {
            var service = ServiceFactory.CreateAuthorService();

            var authors = service.GetAllAuthors();
            Assert.IsNotNull(authors);

            Assert.IsTrue(authors.Any());
        }
    }
}
