using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoshanTarAzAftab.Infrastructure.EF.Models;

namespace RoshanTarAzAftab.Infrastructure.EF.Config;

internal sealed class ReadConfiguration : IEntityTypeConfiguration<PostReadModel>, IEntityTypeConfiguration<CategoryReadModel>, 
    IEntityTypeConfiguration<MessageReadModel>, IEntityTypeConfiguration<UserReadModel>
{
    public void Configure(EntityTypeBuilder<PostReadModel> builder)
    {
        builder.ToTable("Post");
        builder.HasKey(p => p.Id);
        builder.Property(p=> p.Title);
        builder.Property(p=> p.PostType)
            .HasConversion<string>();
        builder.Property(p=> p.DatePosted);
        builder.Property(p=> p.Content);
        builder.Property(p=> p.ShortDescription);
        builder.HasOne(p=> p.Category)
            .WithMany(c=> c.Posts)
            .HasForeignKey(p=> p.CategoryId);
    }

    public void Configure(EntityTypeBuilder<CategoryReadModel> builder)
    {
        builder.ToTable("Category");
        builder.HasKey(c=> c.Id);
        builder.Property(c=> c.Name);
        builder.HasMany(c => c.Posts)
               .WithOne(p => p.Category)
               .HasForeignKey(p=> p.CategoryId);
    }

    public void Configure(EntityTypeBuilder<MessageReadModel> builder)
    {
        builder.ToTable("Message");
        builder.HasKey(m=> m.Id);
        builder.Property(m=> m.SenderName);
        builder.Property(m=> m.SenderEmail);
        builder.Property(m=> m.Content);
    }

    public void Configure(EntityTypeBuilder<UserReadModel> builder)
    {
        builder.ToTable("User");
        builder.HasKey(u=> u.Id);
        builder.Property(u=> u.FullName);
        builder.Property(u=> u.Email);
        builder.Property(u=> u.ActivationCode);
        builder.Property(u=> u.IsRegistered);
    }
}
