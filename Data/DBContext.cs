namespace TGDD_Clone_2.Data;
using Microsoft.EntityFrameworkCore;
using TGDD_Clone_2;


public class DBContext : DbContext
{
    public DBContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Phone> Phones { get; set; }
    public DbSet<Laptop> Laptops { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Address> Addresses { get; set; }
}