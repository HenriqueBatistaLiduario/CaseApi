using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class SubjectMap : IEntityTypeConfiguration<SubjectEntity>
    {
        public void Configure(EntityTypeBuilder<SubjectEntity> builder)
        {
            builder.ToTable("subjects"); //Nome da tabela

            builder.HasKey(SBJ => SBJ.GUID); //Chave primária

            //Propertyes
            builder.Property(SBJ => SBJ.SBJNAME).IsRequired().HasMaxLength(255); //Nome do curso
            builder.Property(SBJ => SBJ.SBJTYPE).IsRequired(); //TIPO: { 1=GRADUAÇÃO,2=PÓS-GRADUAÇÃO,3=EXTENSÃO }
            builder.Property(SBJ => SBJ.SBJSUBTYPE); //SUBTIPO: { 1=BACHARELADO,2=LICENCIATURA,3=TECNÓLOGO }
            builder.Property(SBJ => SBJ.SBJMODALITY).IsRequired(); //MODALIDADE: { 1=EAD,2=PRESENCIAL,3=HÍBRIDO 
            builder.Property(SBJ => SBJ.SBJWORKLOAD).IsRequired(); //Carga horária do Curso
            builder.Property(SBJ => SBJ.SBJOFFERABLE).IsRequired(); //OFERTÁVEL? {1=SIM, 2=NÃO} - Chave para ativar/desativar novas ofertas desse curso.
            builder.Property(SBJ => SBJ.SBJOFFERABLESYNCE); //OFERTÁVEL DESDE - Data de ativação/desativação da oferta desse curso          

            //Indexes

        }
    }
}
