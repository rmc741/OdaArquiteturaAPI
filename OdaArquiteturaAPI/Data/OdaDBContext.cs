using Microsoft.EntityFrameworkCore;
using OdaArquiteturaAPI.Entity;

namespace OdaArquiteturaAPI.Data;

public class OdaDBContext : DbContext
{
    public OdaDBContext(DbContextOptions<OdaDBContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Project> Projects { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
