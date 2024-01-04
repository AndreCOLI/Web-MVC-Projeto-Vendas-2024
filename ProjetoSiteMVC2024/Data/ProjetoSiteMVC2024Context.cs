using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoSiteMVC2024.Models;

namespace ProjetoSiteMVC2024.Data
{
    public class ProjetoSiteMVC2024Context : DbContext
    {
        public ProjetoSiteMVC2024Context (DbContextOptions<ProjetoSiteMVC2024Context> options)
            : base(options)
        {
        }

        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<Vendedor> Vendedor { get; set; }
        public DbSet<RegistroVendas> RegistroVendas { get; set; }



    }
}
