using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class StudentMap : IEntityTypeConfiguration<StudentEntity>
    {
        public void Configure(EntityTypeBuilder<StudentEntity> builder)
        {
            builder.ToTable("students"); //Nome da tabela

            builder.HasKey(STD => STD.GUID); //Chave primária

            //Propertyes
            builder.Property(STD => STD.STDFULLNAME).IsRequired().HasMaxLength(255); //Nome do aluno
            builder.Property(STD => STD.STDSOCIALNAME).IsRequired().HasMaxLength(255); //Nome social do aluno
            builder.Property(STD => STD.STDREGISTRATION).IsRequired().HasMaxLength(32); //RA (Código de matrícula)
            builder.Property(STD => STD.STDDOCTYPE).HasMaxLength(32); //Tipo de Documento de Identificação (RG, CPF, CNH, etc)
            builder.Property(STD => STD.STDDOCID).HasMaxLength(32); //Documento de Identificação
            builder.Property(STD => STD.STDEMAIL).IsRequired().HasMaxLength(100); // E-mail do aluno
            builder.Property(STD => STD.STDPHONE).HasMaxLength(32); //Telefone do aluno
            builder.Property(STD => STD.STDBIRTHDATE).IsRequired(); //Data de Nascimento           

            //Indexes
            builder.HasIndex(STD => STD.STDREGISTRATION).IsUnique();
            builder.HasIndex(STD => STD.STDEMAIL).IsUnique();

        }
    }
}
