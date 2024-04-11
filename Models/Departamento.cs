using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Gestao.Models
{
    public class Departamento
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Informe o Nome")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Informe o Local")]
        public string Local { get; set; }
        public List<Funcionario>? Funcionarios { get; set; }

        public Departamento()
        {
            Funcionarios = new List<Funcionario>();
        }
    }
}