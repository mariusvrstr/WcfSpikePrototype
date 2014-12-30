
namespace Spike.Contracts.Books
{
    using System;
    using System.Runtime.Serialization;
    using Authors;

    [DataContract(Namespace = "Spike.Contracts.Books")]
    public class Book
    {
        protected bool Equals(Book other)
        {
            return Id.Equals(other.Id) && string.Equals(Title, other.Title) && Equals(Author, other.Author) && ReleaseDate.Equals(other.ReleaseDate);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Book) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = Id.GetHashCode();
                hashCode = (hashCode*397) ^ (Title != null ? Title.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (Author != null ? Author.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ ReleaseDate.GetHashCode();
                return hashCode;
            }
        }

        [DataMember]
        public Guid Id { get; set; }

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public Author Author { get; set; }

        [DataMember]
        public DateTime ReleaseDate { get; set; }
    }
}
