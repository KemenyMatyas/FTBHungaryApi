namespace FTBHungary.DataAccess;

using Data.Models;
using Microsoft.EntityFrameworkCore;

public class FTBHungaryContext : DbContext
{
    public FTBHungaryContext(DbContextOptions<FTBHungaryContext> options): base(options) { }
    
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<User>(entity =>
        {
            entity.HasKey(k => k.Id);
        });
    }

}