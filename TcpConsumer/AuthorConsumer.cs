
namespace Spikes.TcpConsumer
{
    using System;
    using System.Collections.Generic;
    using AuthorProxy;

    public class AuthorConsumer
    {
        public Author AddAuthor(AddAuthorRequest request)
        {
            Author author;

            // Warning! this approach could leave open failed connections
            using (var proxy = new AuthorServiceClient())
            {
                proxy.Open();
                author = proxy.AddAuthor(request);
                proxy.Close();
            }

            return author;
        }

        public Author GetAuthorById(Guid authorId)
        {
            Author author;

            // Warning! this approach could leave open failed connections
            using (var proxy = new AuthorServiceClient())
            {
                proxy.Open();
                author = proxy.GetAuthorById(authorId);
                proxy.Close();
            }

            return author;
        }

        public IEnumerable<Author> GetAllAuthors()
        {
            IEnumerable<Author> authors;

            // Warning! this approach could leave open failed connections
            using (var proxy = new AuthorServiceClient())
            {
                proxy.Open();
                authors = proxy.GetAllAuthors();
                proxy.Close();
            }

            return authors;
        }
    }
}
