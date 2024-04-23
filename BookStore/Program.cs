using BookStore.Data;
using BookStore.Models;
// Create

BookStoreContext bookStore = new();

//bookStore.Libraries.Add(new() { Name = "Lorem", LimitBookCount = 150 });
bookStore.Books.Add(new() { Title = "Ipsum", Author = "Ipsumov Lorem", LibraryId = 2 });
bookStore.SaveChanges();

// Read

foreach (Book book in bookStore.Books.ToList())
{
    Console.WriteLine(book.Title);
}

// Update
Book? existingBook = bookStore.Books.FirstOrDefault(b => b.Id == 3);
if (existingBook is Book)
{
    existingBook.Author = "Mahammad";
    bookStore.SaveChanges();
}

// delete
bookStore.Books.Remove(existingBook);
bookStore.SaveChanges();
