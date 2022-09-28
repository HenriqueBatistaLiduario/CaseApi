using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Data.Mapping
{
    public class ProfileMap : IEntityTypeConfiguration<ProfileEntity>
    {
        public void Configure(EntityTypeBuilder<ProfileEntity> builder)
        {
            builder.ToTable("profiles"); //Nome da tabela

            builder.HasKey(PFL => PFL.GUID); //Chave primária

            //Propertyes
            builder.Property(PFL => PFL.PFLALIAS);
            builder.Property(PFL => PFL.PFLTITLE);
            builder.Property(PFL => PFL.PFLASSIGNMENTS);

            //Indexes
            builder.HasIndex(PFL => PFL.PFLALIAS).IsUnique();
        }
    }
}
