
class Book : IClone<Book>
{
    private string title;

    private string author;

    public Book(string title, string author)
    {
        this.title = title;
        this.author = author;
    }

    private Book(Book book)
    {
        this.title = book.title;
        this.author = book.author;
    }

    public Book Clone(Book book)
    {
        return new(book);
    }

    public string GetBookInfo() //Added this to demonstrate it not working
    {
        return $"{title}, {author}";
    }

    public void ChangeBookInfo()
    {
        title = "1983";
    }
}