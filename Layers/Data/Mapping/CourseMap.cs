using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mapping
{
    public class CourseMap : IEntityTypeConfiguration<CourseEntity>
    {
        public void Configure(EntityTypeBuilder<CourseEntity> builder)
        {
            builder.ToTable("courses"); //Nome da tabela

            builder.HasKey(CUR => CUR.GUID); //Chave primária

            //Propertyes
            builder.Property(CUR => CUR.CURNAME).IsRequired().HasMaxLength(255); //Nome do curso
            builder.Property(CUR => CUR.CURTYPE).IsRequired(); //TIPO: { 1=GRADUAÇÃO,2=PÓS-GRADUAÇÃO,3=EXTENSÃO }
            builder.Property(CUR => CUR.CURSUBTYPE); //SUBTIPO: { 1=BACHARELADO,2=LICENCIATURA,3=TECNÓLOGO }
            builder.Property(CUR => CUR.CURMODALITY).IsRequired(); //MODALIDADE: { 1=EAD,2=PRESENCIAL,3=HÍBRIDO 
            builder.Property(CUR => CUR.CURWORKLOAD).IsRequired(); //Carga horária do Curso
            builder.Property(CUR => CUR.CUROFFERABLE).IsRequired(); //OFERTÁVEL? {1=SIM, 2=NÃO} - Chave para ativar/desativar novas ofertas desse curso.
            builder.Property(CUR => CUR.CUROFFERABLESYNCE); //OFERTÁVEL DESDE - Data de ativação/desativação da oferta desse curso          

            //Indexes

        }
    }
}
