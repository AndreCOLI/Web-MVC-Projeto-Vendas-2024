using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoSiteMVC2024.Models;
using ProjetoSiteMVC2024.Models.Enums;

namespace ProjetoSiteMVC2024.Data
{
    public class ServicoPopular
    {
        private ProjetoSiteMVC2024Context _context;

        public ServicoPopular(ProjetoSiteMVC2024Context context)
        {
            _context = context;

        }

        public void Populado()
        {
            if (_context.Departamento.Any() || _context.Vendedor.Any() || _context.RegistroVendas.Any())
            {
                return;
            }

            Departamento d1 = new Departamento(3, "Fashion");
            Departamento d2 = new Departamento(4, "Computers");
            Departamento d3 = new Departamento(5, "Carrinhos");
            Departamento d4 = new Departamento(6, "Tabuleiros");


            Vendedor s1 = new Vendedor(1, "Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21), 1000.0, d1);
            Vendedor s2 = new Vendedor(2, "Maria Green", "maria@gmail.com", new DateTime(1979, 12, 31), 3500.0, d2);
            Vendedor s3 = new Vendedor(3, "Alex Grey", "alex@gmail.com", new DateTime(1988, 1, 15), 2200.0, d1);
            Vendedor s4 = new Vendedor(4, "Martha Red", "martha@gmail.com", new DateTime(1993, 11, 30), 3000.0, d4);
            Vendedor s5 = new Vendedor(5, "Donald Blue", "donald@gmail.com", new DateTime(2000, 1, 9), 4000.0, d3);
            Vendedor s6 = new Vendedor(6, "Alex Pink", "bob@gmail.com", new DateTime(1997, 3, 4), 3000.0, d2);

            RegistroVendas r1 = new RegistroVendas(1, new DateTime(2018, 09, 25), 11000.0, StatusVenda.Faturado, s1);
            RegistroVendas r2 = new RegistroVendas(2, new DateTime(2018, 09, 4), 7000.0, StatusVenda.Faturado, s5);
            RegistroVendas r3 = new RegistroVendas(3, new DateTime(2018, 09, 13), 4000.0, StatusVenda.Cancelado, s4);
            RegistroVendas r4 = new RegistroVendas(4, new DateTime(2018, 09, 1), 8000.0, StatusVenda.Faturado, s1);
            RegistroVendas r5 = new RegistroVendas(5, new DateTime(2018, 09, 21), 3000.0, StatusVenda.Faturado, s3);
            RegistroVendas r6 = new RegistroVendas(6, new DateTime(2018, 09, 15), 2000.0, StatusVenda.Faturado, s1);
            RegistroVendas r7 = new RegistroVendas(7, new DateTime(2018, 09, 28), 13000.0, StatusVenda.Faturado, s2);
            RegistroVendas r8 = new RegistroVendas(8, new DateTime(2018, 09, 11), 4000.0, StatusVenda.Faturado, s4);
            RegistroVendas r9 = new RegistroVendas(9, new DateTime(2018, 09, 14), 11000.0, StatusVenda.Pendente, s6);
            RegistroVendas r10 = new RegistroVendas(10, new DateTime(2018, 09, 7), 9000.0, StatusVenda.Faturado, s6);
            RegistroVendas r11 = new RegistroVendas(11, new DateTime(2018, 09, 13), 6000.0, StatusVenda.Faturado, s2);

            _context.Departamento.AddRange(d1, d2, d3, d4);
            _context.Vendedor.AddRange(s1, s2, s3, s4, s5, s6);
            _context.RegistroVendas.AddRange(
                r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
                r11
            );

            _context.SaveChanges();
        }

    }
}
