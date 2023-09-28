using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RoshanTarAzAftab.Domain.Entities;
using RoshanTarAzAftab.Domain.ValueObjects;
using RoshanTarAzAftab.Domain.ValueObjects.Category;
using RoshanTarAzAftab.Domain.ValueObjects.Message;
using RoshanTarAzAftab.Domain.ValueObjects.Post;

namespace RoshanTarAzAftab.Infrastructure.EF.Config;

internal sealed class WriteConfiguration : IEntityTypeConfiguration<Post>, IEntityTypeConfiguration<Category>,
    IEntityTypeConfiguration<Message>, IEntityTypeConfiguration<User>
{
    #region Common Converters
    private ValueConverter _fullNameConverter = new ValueConverter<FullName, string>(fln => fln.Value, fln => new FullName(fln));
    private ValueConverter _emailConverter = new ValueConverter<Email, string>(e => e.Value, e => new Email(e));
    #endregion

    public void Configure(EntityTypeBuilder<Post> builder)
    {
        builder.HasKey(p => p.Id);

        #region Post Converters
        var postTitleConverter = new ValueConverter<PostTitle, string>(ptc => ptc.Value, ptc => new PostTitle(ptc));
        var postTypeConverter = new ValueConverter<RoshanTarAzAftab.Domain.ValueObjects.Post.PostType, RoshanTarAzAftab.Domain.Enums.PostType>(ptc => ptc.Value,
            ptc => new RoshanTarAzAftab.Domain.ValueObjects.Post.PostType(ptc));
        var postShortDescConverter = new ValueConverter<PostShortDescription, string>(psdc => psdc.Value, psdc => new PostShortDescription(psdc));
        var postContentConverter = new ValueConverter<PostContent, string>(pcc => pcc.Value, pcc => new PostContent(pcc));
        var postDateConverter = new ValueConverter<Date, DateTime>(pdc => pdc.Value, pdc => new Date(pdc));
        #endregion

        #region Post Table Declaration
        builder.Property(p => p.Id)
            .HasConversion(id => id.Value, id => new BaseEntityId(id));

        builder.Property(typeof(PostTitle), "_title")
                .HasConversion(postTitleConverter)
                .HasColumnName("PostTitle");

        builder.Property(typeof(PostType), "_postType")
                .HasConversion(postTypeConverter)
                .HasConversion<string>()
                .HasColumnName("PostType");

        builder.Property(typeof(PostShortDescription), "_shortDescription")
                .HasConversion(postShortDescConverter)
                .HasColumnName("ShortDescription");

        builder.Property(typeof(PostContent), "_content")
                .HasConversion(postContentConverter)
                .HasColumnName("Content");

        builder.Property(typeof(Date), "_datePosted")
                .HasConversion(postDateConverter)
                .HasColumnName("PostDate");

        builder.HasOne<Category>()
            .WithMany()
            .HasForeignKey("_categoryId")
            .IsRequired();

        builder.ToTable("Users");
        #endregion
    }

    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasKey(p => p.Id);
        #region Category Converters
        var categortNameConverter = new ValueConverter<CategoryName, string>(cnc => cnc.Value, cnc => new CategoryName(cnc));
        #endregion

        #region Category Table Declaration
        builder.Property(p => p.Id)
           .HasConversion(id => id.Value, id => new BaseEntityId(id));

        builder.Property(typeof(CategoryName), "_name")
               .HasConversion(categortNameConverter)
               .HasColumnName("CategoryName");

        builder.HasMany<Post>()
           .WithOne()
           .HasForeignKey("_categoryId")
           .IsRequired();
        #endregion
    }

    public void Configure(EntityTypeBuilder<Message> builder)
    {
        builder.HasKey(m => m.Id);

        #region Message Converters
        var messageConverter = new ValueConverter<MessageContent, string>(mc => mc.Value, mc => new MessageContent(mc));
        #endregion

        #region Message Table Declaration
        builder.Property(m => m.Id)
            .HasConversion(id => id.Value, id => new BaseEntityId(id));

        builder.Property(typeof(FullName), "_fullName")
                .HasConversion(_fullNameConverter)
                .HasColumnName("FullName");

        builder.Property(typeof(Email), "_email")
            .HasConversion(_emailConverter)
            .HasColumnName("Email");

        builder.Property(typeof(MessageContent), "_message")
            .HasConversion(messageConverter)
            .HasColumnName("Content");

        builder.ToTable("Messages");
        #endregion
    }

    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(u => u.Id);
        #region User Converters
        var activationCodeConverter = new ValueConverter<ActivationCode, string>(acc => acc.Value, acc => new ActivationCode(acc));
        #endregion

        #region User Table Declaration
        builder.Property(m => m.Id)
            .HasConversion(id => id.Value, id => new BaseEntityId(id));

        builder.Property(typeof(FullName), "_fullName")
                .HasConversion(_fullNameConverter)
                .HasColumnName("FullName");

        builder.Property(typeof(Email), "_email")
            .HasConversion(_emailConverter)
            .HasColumnName("Email");

        builder.Property(typeof(ActivationCode), "_activationCode")
            .HasConversion(activationCodeConverter)
            .HasColumnName("ActivationCode");

        builder.Property(typeof(bool), "_isRegistered")
            .HasColumnName("IsRegistered");

        builder.ToTable("Users");
        #endregion
    }
}
