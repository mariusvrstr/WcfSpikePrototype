
namespace Spike.Contracts.Authors
{
    using System;
    using System.Runtime.Serialization;

    [DataContract(Namespace = "Spike.Contracts.Authors")]
    public class Author
    {
        protected bool Equals(Author other)
        {
            return Id.Equals(other.Id) && string.Equals(Name, other.Name) && string.Equals(Surname, other.Surname) && BirthDay.Equals(other.BirthDay);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Author) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = Id.GetHashCode();
                hashCode = (hashCode*397) ^ (Name != null ? Name.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (Surname != null ? Surname.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ BirthDay.GetHashCode();
                return hashCode;
            }
        }

        [DataMember]
        public Guid Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Surname { get; set; }

        [DataMember]
        public DateTime BirthDay { get; set; }
    }
}
