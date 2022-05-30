using System.Collections.Generic;
using Tutor_01_GET_POST;

public class BookDataList : IBookDataList
{
    List<Books> books = new List<Books>();

    public void AddBooks(Books book)
    {
        books.Add(book);
    }

    public void DeleteBook(string n)
    {
        for (int i = 0; i < books.Count; i++)
        {
            if (books[i].Title == n)
            {
                books.RemoveAt(i);
            }

        } 
    }

    public IEnumerable<Books> GetBooks()
    {
        return books;
    }
}