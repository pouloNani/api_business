using System;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Data;
// options : sql connection string
// register this class as a service in our application
public class StoreContext(DbContextOptions options) : DbContext(options)
{
    
    public DbSet<Product> Products {get;set;}
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProductConfiguration).Assembly);
    }
}
