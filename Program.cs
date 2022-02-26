List<Book> bookList = new();
Console.WriteLine("Test that is not working:");
Book bookPrototype1 = new("1984", "George Orwell");
//Example of it not working, due to the cloned book being a reference 
Book clonedBook1 = bookPrototype1;
bookPrototype1.ChangeBookInfo();
bookList.Add(bookPrototype1);
bookList.Add(clonedBook1);
foreach (Book book in bookList)
{
    Console.WriteLine(book.GetBookInfo());
}

List<Book> bookList2 = new();
Console.WriteLine("Test that is working:");
Book bookPrototype2 = new("1984", "George Orwell");
//With the clone method, it's working 
bookList2.Add(bookPrototype2);
bookList2.Add(bookPrototype2.Clone(bookPrototype2));
bookPrototype2.ChangeBookInfo();
foreach (Book book in bookList2)
{
    Console.WriteLine(book.GetBookInfo());
}


