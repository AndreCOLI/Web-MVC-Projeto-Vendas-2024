using ProjetoSiteMVC2024.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoSiteMVC2024.Models;

namespace ProjetoSiteMVC2024.Services
{
    public class VendedorService
    {
        private readonly ProjetoSiteMVC2024Context _context;

        public VendedorService(ProjetoSiteMVC2024Context context)
        {

            _context = context;
        }

        public List<Vendedor> EncontrarTodos()
        {
            return _context.Vendedor.ToList();
        }


    }
}
