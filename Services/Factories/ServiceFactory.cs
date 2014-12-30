
using Spike.Contracts.Services;

namespace Spike.Services.Factories
{
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
