using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Domain.DTOs
{
    public class LoginDto
    {
        [Required(ErrorMessage = "Digite um e-mail para login")]
        [EmailAddress(ErrorMessage = "Isso não parece um e-mail (formato inválido)")]
        [StringLength(100, ErrorMessage = "O e-mail deve ter no máximo {1} caracteres")]
        public string UserEmail { get; set; }
    }
}
