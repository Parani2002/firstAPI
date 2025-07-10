using System.Configuration;
using FirstAPI.Data;
using FirstAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        static string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        // private static List<Book> books = new List<Book>
        // {
        //     new Book { Id = 1, Title = "1984", Author = "George Orwell", PublishedDate = 1949 },
        //     new Book { Id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", PublishedDate = 1960 }
        // };

        private readonly FirstAPIContext _context;

        public BooksController(FirstAPIContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<Book>> GetBooks()
        {
            var books = _context.Books.ToList();
            return Ok(books);
        }
        [HttpGet("{id}")]
        public ActionResult<Book> GetBook(int id)
        {
            var book = _context.Books.FirstOrDefault(b => b.Id == id);
            if (book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }
        



    } 
}
