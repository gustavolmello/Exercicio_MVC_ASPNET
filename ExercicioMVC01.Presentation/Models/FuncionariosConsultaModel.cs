using ExercicioMVC01.Repository.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioMVC01.Presentation.Models
{
    public class FuncionariosConsultaModel
    {
        
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Matricula { get; set; }
        public decimal Salario { get; set; }
        public DateTime DataCadastro { get; set; }

        public List<Funcionario> Funcionarios { get; set; }
    }
}
