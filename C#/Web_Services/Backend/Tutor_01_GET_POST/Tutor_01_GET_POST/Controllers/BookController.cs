using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Tutor_01_GET_POST.Controllers
{
    //[ApiController]
    [Route("Books")]
    public class BookController : ControllerBase
    {
        #region List
        static private List<Books> bookList = new List<Books>();
        //private List<Books> bookList = new List<Books>();
        #endregion

        private IBookDataList _data;
        public BookController(IBookDataList data)
        {
            _data = data;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Books>> Get()
        {
            return Ok(bookList);
            
            //return Ok(_data.GetBooks());
        }
        [HttpDelete]
        public ActionResult Delete(string n)
        {
            _data.DeleteBook(n);
            return Ok(n +  "is deleted");
        }


        [HttpPost]
        public ActionResult Post([FromBody] Books b)
        {
            bookList.Add(b);
            
            
            //_data.AddBooks(b);
            return Ok("Book Added");
        }
    }
}
