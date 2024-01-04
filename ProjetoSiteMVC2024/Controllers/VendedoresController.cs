using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoSiteMVC2024.Services;

namespace ProjetoSiteMVC2024.Controllers
{
    public class VendedoresController : Controller
    {

        private readonly VendedorService _vendedorservice;

        public VendedoresController(VendedorService vendedorService)
        {
            _vendedorservice = vendedorService;
        
        }
        
        
        
        public IActionResult Index()
        {
            var lista = _vendedorservice.EncontrarTodos();
            return View(lista);
        }
    }
}
