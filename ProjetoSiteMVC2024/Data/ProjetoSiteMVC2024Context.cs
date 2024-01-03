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

        public DbSet<ProjetoSiteMVC2024.Models.Departamento> Departamento { get; set; }
    }
}
