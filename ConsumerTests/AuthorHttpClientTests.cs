
namespace Spike.ConsumerTests
{
    using System;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using HttpConsumer;
    using StubData.Builders;

    [TestClass]
    public class AuthorHttpClientTests
    {
        [TestInitialize]
        public void InitializeTest()
        {
            // The static database stub class lives in a different context (No Object Mother)
        }

        [TestCleanup]
        public void TestCleanup()
        {
            // The static database stub class lives in a different context (No Object Mother)
        }

        [TestMethod] // The HttpHost console app must be running
        public void TestAddAuthorFromClientTest()
        {
            var consumer = new AuthorConsumer();
            var request = new AuthorBuilder().WilburSmith().BuildAddAuthorRequest();

            var response = consumer.AddAuthor(request);
            Assert.IsNotNull(response);

            var assertAuthor = new AuthorBuilder(response.Id).WilburSmith().Build();
            Assert.AreEqual(assertAuthor, response);
        }


        [TestMethod] // The Httpost console app must be running
        public void TestGetAllAuthorFromClientTest()
        {
            var consumer = new AuthorConsumer();

            var response = consumer.GetAllAuthors().ToList();
            Assert.IsNotNull(response);

            Console.WriteLine(string.Format("[{0}] Authors found", response.Count()));
            Assert.IsTrue(response.Any());
        }
    }
}
