using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using InfnetMVC.Models;

namespace InfnetMVC.Models
{
    public class Funcionario
    {
        [Key]
        public int FuncionarioId { get; set; }

        [Required(ErrorMessage = "Informe o Nome")]
        [StringLength(50, ErrorMessage = "Só pode até 50 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o Endereço")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Informe o Telefone")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Informe o Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe a Data de Nascimento")]
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }

        // Foreign key relationship with Departamento
        [ForeignKey("DepartamentoId")]
        public int DepartamentoId { get; set; }
        public Departamento Departamento { get; set; } // Navigation property for Departamento
    }
}