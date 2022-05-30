using System.Collections.Generic;
using Tutor_01_GET_POST;

public interface IBookDataList
{
    void AddBooks(Books book);
    IEnumerable<Books> GetBooks();
    void DeleteBook(string n);
}