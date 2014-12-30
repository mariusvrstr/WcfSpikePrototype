
namespace Spike.StubData.ObjectMother
{
    using System.Collections.Generic;
    using Contracts.Authors;
    using Contracts.Books;

    public class ObjectMother
    {
        private static ObjectMother _instance;

        public static ObjectMother Instance
        {
            get
            {
                return _instance ?? Initialize();
            }
        }

        public AuthorData Authors { get; set; }
        public BookData Books { get; set; }

        public static ObjectMother Initialize()
        {
            if (_instance == null)
            {
                _instance = new ObjectMother();
            }

            _instance.Authors = new AuthorData().Init();
            _instance.Books = new BookData().Init();

            return _instance;
        }

        public static void Reset()
        {
            DatabaseStub.Database.Books = new List<Book>();
            DatabaseStub.Database.Authors = new List<Author>();

            _instance = null;
        }
    }
}
