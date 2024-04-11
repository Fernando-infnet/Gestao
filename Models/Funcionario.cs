using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Gestao.Models
{
    public class Funcionario
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Informe o Nome")]
        public string Nome { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "Informe o Endereço")]
        public string Endereco { get; set; } = string.Empty;
       
        [Required(ErrorMessage = "Informe o Telefone")]
        public string Telefone { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "Informe o Email")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe a Data de Nascimento")]
        public DateTime DataNascimento { get; set; }
    }
}