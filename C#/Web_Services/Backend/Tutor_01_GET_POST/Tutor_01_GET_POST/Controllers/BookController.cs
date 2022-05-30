using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Tutor_01_GET_POST.Data;

namespace Tutor_01_GET_POST.Controllers
{
    //[ApiController]
    [Route("Books")]
    public class BookController : ControllerBase
    {


        private IBookDataContext _data;
        public BookController(IBookDataContext data)
        {
            _data = data;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Books>> Get()
        {
            return Ok(_data.GetBooks());
            
           
        }


        [HttpPost]
        public ActionResult Post([FromBody] Books b)
        {
            _data.AddBook(b);
            
            
            //_data.AddBooks(b);
            return Ok("Book Added");
        }
    }
}
