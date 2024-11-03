using Angular_.Net_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Angular_.Net_API.Controller
{
    [Route("api/[Controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private Book[] _books = new Book[]
        {
            new Book(){Id=1,Title="Rose",Author="James Parker"},
            new Book(){Id=2,Title="Death",Author="Clark Kent"},
            new Book(){Id=3,Title="Enterprise",Author="Jean Dujardin"}
        };

        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetBooks()
        {
            return Ok(_books);
        }


    }
}
