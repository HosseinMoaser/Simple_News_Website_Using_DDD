using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RoshanTarAzAftab.Domain.Entities;
using RoshanTarAzAftab.Infrastructure.EF.Config;
using RoshanTarAzAftab.Infrastructure.EF.Models;

namespace RoshanTarAzAftab.Infrastructure.EF.Context;

internal sealed class WriteDbContext : DbContext
{
    public DbSet<Post> Posts { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Message> Messages { get; set; }

    public WriteDbContext(DbContextOptions<WriteDbContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var configuration = new WriteConfiguration();
        modelBuilder.ApplyConfiguration<Post>(configuration);
        modelBuilder.ApplyConfiguration<Category>(configuration);
        modelBuilder.ApplyConfiguration<User>(configuration);
        modelBuilder.ApplyConfiguration<Message>(configuration);
    }
}
