
namespace Spike.UnitTests.Factories
{
    using Contracts.Services;
    using Services;

    public static class ServiceFactory
    {
        public static IAuthorService CreateAuthorService()
        {
            return new AuthorService();
        }

        public static IBookService CreateBookService()
        {
            return new BookService();
        }
    }
}
