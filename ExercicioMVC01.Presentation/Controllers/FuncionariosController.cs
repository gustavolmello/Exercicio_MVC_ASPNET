using ExercicioMVC01.Presentation.Models;
using ExercicioMVC01.Repository.Entities;
using ExercicioMVC01.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioMVC01.Presentation.Controllers
{
    public class FuncionarioController : Controller
    {
        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(FuncionarioCadastroModel model, [FromServices] IFuncionarioRepository funcionarioRepository)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var funcionario = new Funcionario();

                    funcionario.IdFuncionario = Guid.NewGuid();
                    funcionario.Nome = model.Nome;
                    funcionario.Cpf = model.Cpf;
                    funcionario.Matricula = model.Matricula;
                    funcionario.Salario = decimal.Parse(model.Salario);
                    funcionario.DataCadastro = DateTime.Now;

                    funcionarioRepository.Inserir(funcionario);

                    TempData["MensagemSucesso"] = $"Funcionario {funcionario.Nome}, cadastrado com sucesso.";

                    ModelState.Clear();
                }

                catch (Exception e)
                {
                    TempData["MensagemErro"] = $"Erro {e.Message}";
                }
            }

            return View();
        }

        public IActionResult Consulta()
        {
            return View();
        }

        [HttpPost] 
        public IActionResult Consulta(FuncionariosConsultaModel model, [FromServices] IFuncionarioRepository funcionarioRepository)
        {
            model.Funcionarios = funcionarioRepository.Consultar();
            
            return View(model);
        }
    }
}
