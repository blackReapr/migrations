using BookStore.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Data;

internal class BookStoreContext:DbContext
{
    public DbSet<Book> Books { get; set; }
    public DbSet<Library> Libraries { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=DESKTOP-C20TBEU;Database=BookStore;Trusted_Connection=True;TrustServerCertificate=Yes;");
        base.OnConfiguring(optionsBuilder);
    }
}
