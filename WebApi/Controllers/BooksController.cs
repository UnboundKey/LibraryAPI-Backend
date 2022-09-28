using DataAccess.EFCore.UnitOfWork;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]

    [ApiController]
    public class BooksController : ControllerBase
    {

        private readonly IUnitOfWork _unitOfWork;
        public BooksController(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        // GET api/<BooksController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var books = _unitOfWork.Books.GetById(id);
            return Ok(books);
        }


        // GET: api/<BooksController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_unitOfWork.Books.GetAll());
        }

        // POST api/<BooksController>
        [HttpPost]
        public ActionResult Post([FromBody] Book newBook)
        {
            _unitOfWork.Books.Add(newBook);
            _unitOfWork.Complete();
            return Ok(newBook);
        }

        // PUT api/<BooksController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Book changedBook)
        {

            _unitOfWork.Books.Update(changedBook);
            _unitOfWork.Complete();
            return Ok(changedBook);
        }

        // DELETE api/<BooksController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var bookToDelete = _unitOfWork.Books.GetById(id);
            _unitOfWork.Books.Remove(bookToDelete);
            _unitOfWork.Complete();
        }
    }
}
