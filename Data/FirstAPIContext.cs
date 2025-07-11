using System;
using FirstAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace FirstAPI.Data;

public class FirstAPIContext : DbContext
{
    public FirstAPIContext(DbContextOptions<FirstAPIContext> options)
        : base(options)
    {

    }
    public DbSet<Book> Books { get; set; }
    public DbSet<User> Users { get; set; }
        
}
