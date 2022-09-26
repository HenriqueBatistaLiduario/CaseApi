using System;

namespace Api.Domain.Entities
{
    public class CourseEntity : BaseEntity
    {
        public string CURNAME { get; set; } //Nome do curso
        public int CURTYPE { get; set; } //TIPO: { 1=GRADUAÇÃO,2=PÓS-GRADUAÇÃO,3=EXTENSÃO }
        public int CURSUBTYPE { get; set; } //TIPO: { 1=BACHARELADO,2=LICENCIATURA,3=TECNÓLOGO }
        public int CURMODALITY { get; set; } //MODALIDADE: { 1=EAD,2=PRESENCIAL,3=HÍBRIDO }
        public int CURWORKLOAD { get; set; } //Carga horária do Curso
        public int CUROFFERABLE { get; set; } //OFERTÁVEL? {1=SIM, 2=NÃO} - Chave para ativar/desativar novas ofertas desse curso.
        public DateTime CUROFFERABLESYNCE { get; set; } //OFERTÁVEL DESDE - Data de ativação/desativação da oferta desse curso
    }
}
