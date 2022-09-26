using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Api.Data.Mapping
{
    public class SubjectsCoursesMap : IEntityTypeConfiguration<SubjectsCoursesEntity>
    {
        public void Configure(EntityTypeBuilder<SubjectsCoursesEntity> builder)
        {
            builder.ToTable("subjects_courses");

            //Chaves
            builder.HasKey(SBJXCUR => SBJXCUR.GUID);

            builder.Property(SBJXCUR => SBJXCUR.CURGUID); //Curso
            builder.Property(SBJXCUR => SBJXCUR.SBJGUID); //Disciplina      

        }
    }
}
