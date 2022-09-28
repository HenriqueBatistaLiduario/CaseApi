using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class BillEntity : BaseEntity
    {
        public string STDGUID { get; set; } //Student
        public string STDREGISTRATION { get; set; } //Student
        public string STDFULLNAME { get; set; } //Student
        public string CURGUID { get; set; } //Course
        public string CURNAME { get; set; } //Course
        public string SBJGUID { get; set; } //Subject
        public string SBJNAME { get; set; } //Subject
        public string BLTPERIOD { get; set; } //Período de obtenção da nota
        public int BLTTYPE { get; set; } //Tipo de boletim {1=NORMAL, 2=AE (Aproveitamento de Estudos), 3=PRR}
        public float BLTEVALACTIVITY1 { get; set; } //Nota da atividade avaliativa 1
        public float BLTEVALACTIVITY2 { get; set; } //Nota da atividade avaliativa 2
        public float BLTEVALACTIVITY3 { get; set; } //Nota da atividade avaliativa 3
        public float BLTEVALACTIVITYEND { get; set; } //Nota da atividade avaliativa final    
        public int BLTSTATUS { get; set; } //Status { 0=Matriculado, 1=Cursando, 2=Aprovado, 3=Insatisfatório, 9=Certificado }
        public DateTime BLTDELIVERYDATE { get; set; } //Data da última atualização de Status do boletim.
        [Required] public Guid CourseGUID { get; set; } //UM boletim pode possuir apenas UM curso, e é obrigatório.
        public CourseEntity Course { get; set; }
        [Required] public Guid SubjectGUID { get; set; } //UM boletim pode possuir apenas UMA disciplina, e é obrigatório.
        public SubjectEntity Subject { get; set; }
        [Required] public Guid StudentGUID { get; set; } //UM boletim pode possuir apenas UM aluno, e é obrigatório.
        public StudentEntity Student { get; set; }

    }
}
