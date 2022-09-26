using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class UserMap : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.ToTable("user");

            builder.HasKey(u => u.GUID);

            builder.Property(u => u.USERNAME)
                  .IsRequired()
                  .HasMaxLength(100);

            builder.HasIndex(u => u.USEREMAIL)
                   .IsUnique();

            builder.Property(u => u.USERBIRTHDATE)
                   .HasMaxLength(100);
        }
    }
}
