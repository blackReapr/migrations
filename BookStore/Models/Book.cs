using System.ComponentModel.DataAnnotations;

namespace BookStore.Models;

internal class Book
{
    public int Id { get; set; }

    [Required]
    public string Title { get; set; }

    [Required]
    public string Author { get; set; }

    [Required]
    public int LibraryId { get; set; }

    public Library Library { get; set; }
}   
