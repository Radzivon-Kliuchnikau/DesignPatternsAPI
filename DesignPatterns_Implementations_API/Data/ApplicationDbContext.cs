using DesignPatterns_Implementations_API.Creational.FactoryMethod.Models;
using Microsoft.EntityFrameworkCore;

namespace DesignPatterns_Implementations_API.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    
    public DbSet<GroundShipping> GroundShippings { get; set; }
    
    public DbSet<AirShipping> AirShippings { get; set; }
    
    public DbSet<SeaShipping> SeaShippings { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<GroundShipping>().ToTable("GroundShippingsRegistered");
        modelBuilder.Entity<AirShipping>().ToTable("AitShippingsRegistered");
        modelBuilder.Entity<SeaShipping>().ToTable("SeaShippingsRegistered");
    }
}