using LiteDB;
using System.Collections;
using System.Collections.Generic;

namespace Tutor_01_GET_POST.Data
{
    public class BookDataBase :IBookDataContext
    {
        LiteDatabase db = new LiteDatabase(@"data.db");
        public void AddBook(Books b)
        {
            db.GetCollection<Books>("Books").Insert(b);
        }

        public IEnumerable<Books> GetBooks()
        {
            return db.GetCollection<Books>("Books").FindAll();
        }
    }
}
