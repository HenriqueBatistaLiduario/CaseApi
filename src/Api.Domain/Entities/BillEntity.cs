using System;

namespace Api.Domain.Entities
{
    public class BillEntity : BaseEntity
    {
        public string STDGUID { get; set; } //Student
        public string CURGUID { get; set; } //Course
        public string SBJGUID { get; set; } //Subject
        public string BLTPERIOD { get; set; } //Período de obtenção da nota
        public int BLTTYPE { get; set; } //Tipo de boletim {1=NORMAL, 2=AE (Aproveitamento de Estudos), 3=PRR}
        public float BLTEVALACTIVITY1 { get; set; } //Nota da atividade avaliativa 1
        public float BLTEVALACTIVITY2 { get; set; } //Nota da atividade avaliativa 2
        public float BLTEVALACTIVITY3 { get; set; } //Nota da atividade avaliativa 3
        public float BLTEVALACTIVITYEND { get; set; } //Nota da atividade avaliativa final    
        public int BLTSTATUS { get; set; } //Status { 0=Matriculado, 1=Cursando, 2=Aprovado, 3=Insatisfatório, 4=PRR, 9=Certificado }
        public DateTime BLTDELIVERYDATE { get; set; } //Data da última atualização de Status do boletim.

    }
}