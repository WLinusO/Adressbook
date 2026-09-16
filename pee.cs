class Program
{

    static void Main()
    {
        Book book1 = new("Dune", "Frank Herbert");
        Book book2 = new("Frankenstein", "Mary Shelley");

        Console.WriteLine(book1.title + " " + book1.author);


    }

}

class Book
{
    public string title;
    public string author;

    public Book(string bookTitle, string bookAuthor)
    {
        title = bookTitle;
        author = bookAuthor;

    }

}