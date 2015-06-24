
namespace Spike.TcpConsumer
{
    using System;
    using System.Collections.Generic;
    using Contracts.Authors;
    using Contracts.Authors.Requests;
    using Contracts.Consumers;
    using AuthorProxy;

    public class AuthorConsumer
    {
        public Author AddAuthor(AddAuthorRequest request)
        {
            Author author;

            var consumer = new ServiceClientWrapper<AuthorServiceClient, IAuthorService>();
            if (consumer.IsServiceAvailabe())
            {
                author = consumer.Excecute(service => service.AddAuthor(request));
            }
            else throw new Exception(@"Service is not available, please check that the host have been started [TcpHost\bin\Debug\Spikes.TcpHost.exe]");

            return author;
        }

        public Author GetAuthorById(Guid authorId)
        {
            Author author;

            var consumer = new ServiceClientWrapper<AuthorServiceClient, IAuthorService>();
            if (consumer.IsServiceAvailabe())
            {
                author = consumer.Excecute(service => service.GetAuthorById(authorId));
            }
            else throw new Exception(@"Service is not available, please check that the host have been started [TcpHost\bin\Debug\Spikes.TcpHost.exe]");

            return author;
        }

        public IEnumerable<Author> GetAllAuthors()
        {
            IEnumerable<Author> authors;

            var consumer = new ServiceClientWrapper<AuthorServiceClient, IAuthorService>();
            if (consumer.IsServiceAvailabe())
            {
                authors = consumer.Excecute(service => service.GetAllAuthors());
            }
            else throw new Exception(@"Service is not available, please check that the host have been started [TcpHost\bin\Debug\Spikes.TcpHost.exe]");

            return authors;
        }
    }
}
