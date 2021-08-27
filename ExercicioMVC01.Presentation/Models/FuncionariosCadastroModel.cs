using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioMVC01.Presentation.Models
{
    public class FuncionarioCadastroModel
    {
        [MinLength(6, ErrorMessage = "Por favor informe no mínimo {1} caracteres")]
        [MaxLength(150, ErrorMessage = "Por favor informe no máximo {1} caracteres")]
        [Required(ErrorMessage = "Por favor, informe o nome do funcionário.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Por favor, informe o CPF do funcionário.")] 
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Por favor, informe a matrícula do funcionário.")] 
        public string Matricula { get; set; }

        [Required(ErrorMessage = "Por favor, informe o salário do funcionário.")] 
        public string Salario { get; set; }
    }
}
