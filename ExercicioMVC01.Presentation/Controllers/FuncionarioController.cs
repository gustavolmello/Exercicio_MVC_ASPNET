using ExercicioMVC01.Presentation.Models;
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
        public IActionResult Cadastro(FuncionarioCadastroModel model)
        {
            return View();
        }

        public IActionResult Consulta()
        {
            return View();
        }
    }
}
