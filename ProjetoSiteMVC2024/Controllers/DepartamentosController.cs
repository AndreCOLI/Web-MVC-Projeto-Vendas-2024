using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoSiteMVC2024.Models;

namespace ProjetoSiteMVC2024.Controllers
{
    public class DepartamentosController : Controller
    {
        public IActionResult Index()
        {
            List<Departamento> lista = new List<Departamento>();
            lista.Add(new Departamento { Id = 1, Nome = "Brinquedos" });
            lista.Add(new Departamento { Id = 2, Nome = "Cozinha" });
            return View(lista);
        }
    }
}
