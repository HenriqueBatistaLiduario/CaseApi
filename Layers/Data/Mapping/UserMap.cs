using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mapping
{
    public class UserMap : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.ToTable("user");

            builder.HasKey(USER => USER.GUID);

            builder.Property(USER => USER.USERNAME);
            builder.Property(USER => USER.USEREMAIL);

            builder.HasIndex(USER => USER.USEREMAIL).IsUnique();
        }
    }
}
