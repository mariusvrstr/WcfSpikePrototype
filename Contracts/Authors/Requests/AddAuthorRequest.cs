
namespace Spike.Contracts.Authors.Requests
{
    using System;
    using System.Runtime.Serialization;
    
    [DataContract(Namespace = "Spike.Contracts.Authors.Requests")]
    public class AddAuthorRequest
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Surname { get; set; }

        [DataMember]
        public DateTime BirthDay { get; set; }
    }
}
