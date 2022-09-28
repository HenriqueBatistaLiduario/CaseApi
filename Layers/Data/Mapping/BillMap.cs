using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mapping
{
    public class BillMap : IEntityTypeConfiguration<BillEntity>
    {
        public void Configure(EntityTypeBuilder<BillEntity> builder)
        {
            builder.ToTable("bulletins"); //Nome da tabela

            builder.HasKey(BLT => BLT.GUID); //Chave primária

            //Propertyes
            builder.Property(BLT => BLT.STDGUID).IsRequired(); //Student
            builder.Property(BLT => BLT.STDFULLNAME).IsRequired(); //Student
            builder.Property(BLT => BLT.STDREGISTRATION).IsRequired(); //Student
            builder.Property(BLT => BLT.CURGUID).IsRequired(); //Course
            builder.Property(BLT => BLT.CURNAME).IsRequired(); //Course
            builder.Property(BLT => BLT.SBJGUID).IsRequired(); //Disciplina
            builder.Property(BLT => BLT.SBJNAME).IsRequired(); //Disciplina
            builder.Property(BLT => BLT.BLTPERIOD).IsRequired(); //Período
            builder.Property(BLT => BLT.BLTTYPE); //Tipo de boletim {1=NORMAL, 2=AE (Aproveitamento de Estudos), 3=PRR}
            builder.Property(BLT => BLT.BLTEVALACTIVITY1).HasDefaultValue(0); //Nota da atividade avaliativa 1
            builder.Property(BLT => BLT.BLTEVALACTIVITY2).HasDefaultValue(0); //Nota da atividade avaliativa 2
            builder.Property(BLT => BLT.BLTEVALACTIVITY3).HasDefaultValue(0); //Nota da atividade avaliativa 3
            builder.Property(BLT => BLT.BLTEVALACTIVITYEND).HasDefaultValue(0); //Nota da atividade avaliativa final  
            builder.Property(BLT => BLT.BLTSTATUS).HasDefaultValue(0); //Status { 0=Matriculado, 1=Cursando, 2=Aprovado, 3=Insatisfatório, 4=PRR, 9=Certificado }
            builder.Property(BLT => BLT.BLTDELIVERYDATE); //Data da última atualização de Status do boletim

            //Indexes

        }
    }
}
