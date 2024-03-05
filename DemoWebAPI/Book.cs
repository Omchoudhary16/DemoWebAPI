using MongoDB.Bson;

namespace DemoWebAPI
{
    public class Book
    {
        public ObjectId Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
    }

}
