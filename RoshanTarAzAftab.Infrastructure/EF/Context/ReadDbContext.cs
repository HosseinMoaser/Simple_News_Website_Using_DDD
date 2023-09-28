using Microsoft.EntityFrameworkCore;
using RoshanTarAzAftab.Domain.Entities;
using RoshanTarAzAftab.Infrastructure.EF.Config;
using RoshanTarAzAftab.Infrastructure.EF.Models;

namespace RoshanTarAzAftab.Infrastructure.EF.Context;

internal sealed class ReadDbContext : DbContext
{
    public DbSet<PostReadModel> Post { get; set; }
    public DbSet<CategoryReadModel> Category { get; set; }
    public DbSet<MessageReadModel> Message { get; set; }
    public DbSet<UserReadModel> User { get; set; }

    public ReadDbContext(DbContextOptions<ReadDbContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var configuration = new ReadConfiguration();
        modelBuilder.ApplyConfiguration<PostReadModel>(configuration);
        modelBuilder.ApplyConfiguration<CategoryReadModel>(configuration);
        modelBuilder.ApplyConfiguration<UserReadModel>(configuration);
        modelBuilder.ApplyConfiguration<MessageReadModel>(configuration);
    }

}
