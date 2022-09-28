using System;

namespace Domain.Entities
{
    public class SubjectEntity : BaseEntity
    {
        public string SBJNAME { get; set; } //Nome da disciplina
        public string SBJTYPE { get; set; } //TIPO: { 1=GRADUAÇÃO,2=PÓS-GRADUAÇÃO,3=EXTENSÃO }
        public string SBJSUBTYPE { get; set; } //TIPO: { 1=BACHARELADO,2=LICENCIATURA,3=TECNÓLOGO }
        public string SBJMODALITY { get; set; } //MODALIDADE: { 1=EAD,2=PRESENCIAL,3=HÍBRIDO }
        public string SBJWORKLOAD { get; set; } //Carga horária da disciplina
        public string SBJOFFERABLE { get; set; } //OFERTÁVEL? {1=SIM, 2=NÃO} - Chave para ativar/desativar novas ofertas da disciplina na montagem de cursos.
        public DateTime SBJOFFERABLESYNCE { get; set; } //OFERTÁVEL DESDE - Data de ativação/desativação da oferta dessa disciplina        
        public CourseEntity Courses { get; set; } //Uma disciplina pode estar presente em MUITOS cursos.
    }
}
