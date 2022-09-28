using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class ProfileEntity : BaseEntity
    {
        [Required][MaxLength(10)] public string PFLALIAS { get; set; }
        [Required][MaxLength(100)] public string PFLTITLE { get; set; }
        [Required][MaxLength(255)] public string PFLASSIGNMENTS { get; set; } //Atribuições separadas por ; Ex: {CadastrarAluno,ConsultarNota,CadastrarDisciplina}
        public IEnumerable<UserEntity> Users { get; set; } //UM perfil pode possuir MUITOS usuários
    }
}
