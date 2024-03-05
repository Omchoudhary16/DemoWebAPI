using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace DemoWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly MongoDbContext _context;

        public BooksController(MongoDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Book>> Get()
        {
            var collection = _context.GetCollection<Book>("books");
            var books = collection.Find(book => true).ToList();
            return books;
        }

        [HttpPost]
        public ActionResult<Book> Post(Book book)
        {
            var collection = _context.GetCollection<Book>("books");
            collection.InsertOne(book);
            return book;
        }

        // Implement other CRUD operations (PUT, DELETE) as needed
    }

}
