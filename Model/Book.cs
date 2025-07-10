using System;

namespace FirstAPI.Model;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string Author { get; set; } = null!;
    public int PublishedDate { get; set; }

}
