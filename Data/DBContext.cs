namespace TGDD_Clone.Data;
using Microsoft.EntityFrameworkCore;
using TGDD_Clone;


public class DBContext : DbContext
{
    public DBContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Phone> Phones { get; set; }
    public DbSet<Laptop> Laptops { get; set; }
}