using System.ComponentModel.DataAnnotations;

namespace BookStore.Models;

internal class Library
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    [Range(1, 500)]
    public int LimitBookCount { get; set; }

    public List<Book> Books { get; set; }

}
