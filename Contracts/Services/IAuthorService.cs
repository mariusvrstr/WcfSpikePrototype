
namespace Spike.Contracts.Services
{
    using System;
    using System.Collections.Generic;
    using System.ServiceModel;
    using Authors;
    using Authors.Requests;

    [ServiceContract(Namespace = "Spike.Contracts.Services")]
    public interface IAuthorService
    {
        [OperationContract]
        Author AddAuthor(AddAuthorRequest request);

        [OperationContract]
        IEnumerable<Author> GetAllAuthors();

        [OperationContract]
        Author GetAuthorById(Guid authorId);
    }
}
