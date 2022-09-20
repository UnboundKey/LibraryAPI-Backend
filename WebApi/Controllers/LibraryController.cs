using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [EnableCors("AllowOrigin")]
    [Route("api/Books")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        LibraryDBContext database;
        public LibraryController(LibraryDBContext dBContext)
        {
            this.database = dBContext;
        }

        // GET: api/<LibraryController>
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            var result = database.Books.ToList();
            return result;
        }

        // GET api/<LibraryController>/5
        [HttpGet("{id}")]
        public Book Get(int id)
        {
            var result = database.Books.Where(o => o.Id == id).Single();
            return result;
        }

        // POST api/<LibraryController>
        [HttpPost]
        public void Post([FromBody] Book book)
        {
            var newBook = book;
            database.Books.Add(newBook);
            database.SaveChanges();
        }

        // PUT api/<LibraryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LibraryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var bookToDelete = database.Books.Where(o => o.Id == id).Single();
            database.Remove(bookToDelete);
            database.SaveChanges();
        }
    }
}
