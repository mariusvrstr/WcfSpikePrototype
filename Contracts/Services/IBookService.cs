
namespace Spike.Contracts.Services
{
    using System;
    using System.Collections.Generic;
    using System.ServiceModel;
    using Books;
    using Books.Requests;

    [ServiceContract(Namespace = "Spike.Contracts.Services")]
    public interface IBookService
    {
        [OperationContract]
        Book AddBook(AddBookRequest request);

        [OperationContract]
        IEnumerable<Book> GetAllBooks();

        [OperationContract]
        Book GetBookById(Guid bookId);
    }
}
