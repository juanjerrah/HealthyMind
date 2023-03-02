using Microsoft.EntityFrameworkCore;
using HumorDomain = Domain.Humor.Entities.Humor;


namespace Data.Humor.Contexts;

public class HealthyMindDbContext : DbContext
{
    protected HealthyMindDbContext()
    {
    }

    public HealthyMindDbContext(DbContextOptions<HealthyMindDbContext> options) : base(options)
    { }

    public DbSet<HumorDomain> Humores { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(HealthyMindDbContext).Assembly);
    }
}