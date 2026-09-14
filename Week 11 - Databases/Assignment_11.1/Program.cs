using Assignment_11._1;
using System.Runtime.CompilerServices;

LibraryContext libraryDb = new();

//await libraryDb.Database.EnsureDeletedAsync(); //Deletes Database to demonstrate code
await libraryDb.Database.EnsureCreatedAsync(); //Pauses thread until Database is verified

List<Book> booksCache = new();

AddMockData();
DisplayBooks();

DeleteBook(345623);
DisplayBooks();

void AddMockData()
{
    if(!libraryDb.Books.Any())
    {
        AddBook(124123, "Harry Potter", "Clarice Linspector(?)", "The Boy who lived and spent his live trying to die again");
        AddBook(345623, "BraveHeart", "Randall Wallace", "Story of the legendary 13th-century warrior William Wallace");
        AddBook(867843356, "Don Quixote", "Miguel de Cervantes", "The adventures of the ingenious Don Quixote from La Mancha, Spain");
    }

    UpdateCache();
}

void AddBook(int ISBN, string bookName, string authorName, string description)
{
    libraryDb.Add(
        new Book() { ISBN = ISBN, AuthorName = authorName, Name = bookName, ShortDescription = description }
    );

    libraryDb.SaveChanges();

    UpdateCache();
}

void DeleteBook(int ISBN)
{
    Book? selectedBook = booksCache.FirstOrDefault<Book>(x => x.ISBN == ISBN);

    if (selectedBook == null)
    {
        Console.WriteLine($"------------No Book with the provided ISBN was found------------\n");
        return;
    }

    libraryDb.Remove(selectedBook);
    libraryDb.SaveChanges();

    UpdateCache();

    Console.WriteLine($"------------{selectedBook.Name} deleted!------------\n");
}

void DisplayBooks()
{
    booksCache.ForEach(b => Console.WriteLine(b.ToString()));
}

void UpdateCache()
{
    booksCache = new(libraryDb.Books.ToList<Book>());
}

