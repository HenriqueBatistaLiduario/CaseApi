using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Entities
{
    public class UserEntity : BaseEntity
    {
        [Required]
        public string USERNAME { get; set; }
        [Required]
        public string USEREMAIL { get; set; }
    }
}
