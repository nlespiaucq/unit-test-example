using Microsoft.EntityFrameworkCore;
using BoutiqueWeb.Models;

namespace BoutiqueWeb.Data;

public class BoutiqueWebContext : DbContext
{
    public DbSet<Client> Clients { get; set; } = null!;

    public string DbPath { get; private set; }

    public BoutiqueWebContext()
    {
        // Path to SQLite database file
        DbPath = "BoutiqueWeb.db";
    }

    // The following configures EF to create a SQLite database file locally
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Use SQLite as database
        optionsBuilder.UseSqlite($"Data Source={DbPath}");
    }

}