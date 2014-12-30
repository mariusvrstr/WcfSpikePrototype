
namespace Spike.Contracts.Books.Requests
{
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public class AddBookRequest
    {
        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public Guid AuthorId { get; set; }

        [DataMember]
        public DateTime ReleaseDate { get; set; }
    }
}
