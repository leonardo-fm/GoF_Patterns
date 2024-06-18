namespace Prototype;

public class Book : IPrototype
{
    public string Title;
    public int PageNumber;
    
    private string author;

    public Book(string title, int pageNumber, string author)
    {
        Title = title;
        PageNumber = pageNumber;
        
        this.author = author;
    }

    public string GetAuthor()
    {
        return author;
    }

    public IPrototype Clone()
    {
        return new Book(Title, PageNumber, author);
    }
}
