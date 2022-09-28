using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class StudentEntity : BaseEntity
    {
        public string STDFULLNAME { get; set; } //Nome do aluno
        public string STDSOCIALNAME { get; set; } //Nome social do aluno
        public string STDREGISTRATION { get; set; } //RA (Nº de matrícula)
        public string STDDOCTYPE { get; set; } //Tipo de Documento de identificação
        public string STDDOCID { get; set; } //Tipo de Documento de identificação
        public string STDEMAIL { get; set; } // E-mail do aluno
        public string STDPHONE { get; set; } // Telefone do aluno
        public DateTime STDBIRTHDATE { get; set; } //Data de Nascimento
        public IEnumerable<BillEntity> Bills { get; set; } //UM curso pode possuir MUITAS disciplinas

    }
}
