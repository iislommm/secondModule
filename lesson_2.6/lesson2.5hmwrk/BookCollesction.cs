using System.Runtime.CompilerServices;

namespace lesson_2._6.lesson2._5hmwrk;

public class BookCollesction
{
    private List<Book> _books;

    public BookCollesction ()
    {
        _books = new List<Book>();
    }
       
    public Book AddBook (Book book)
    {
        _books.Add(book);
        return book;    
    }
    public List<Book> GetBookByAuthor (string authorName)
    {
        var booksByAuthorName = new List<Book>();

        foreach (var book in _books)
        {
            if (book.Author == authorName)
            {
                booksByAuthorName.Add(book);
            }
        }
        return booksByAuthorName;
    }
    public List<Book> GetBooksByTitle (string title)
    {
        var booksByLitle = new List<Book>();

        foreach (var book in _books)
        {
            if (book.Title == title)
            {
                booksByLitle.Add(book);
            }  
        }
        return booksByLitle;        
    }


}
