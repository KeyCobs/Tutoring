using System.Collections.Generic;
namespace Tutor_01_GET_POST.Data
{
    public interface IBookDataContext
    {
        void AddBook(Books b);
        IEnumerable<Books> GetBooks();
    }
}
