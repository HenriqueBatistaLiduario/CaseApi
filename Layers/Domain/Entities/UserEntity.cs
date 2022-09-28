using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class UserEntity : BaseEntity
    {
        [Required][MaxLength(100)] public string USERNAME { get; set; }
        [Required][MaxLength(100)] public string USEREMAIL { get; set; }
        [Required] public Guid ProfileGUID { get; set; } //UM usuário pode possuir apenas UM perfil, e é obrigatório.
        public ProfileEntity Profile { get; set; }
    }
}
