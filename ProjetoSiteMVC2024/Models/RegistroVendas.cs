using System;
using ProjetoSiteMVC2024.Models.Enums;

namespace ProjetoSiteMVC2024.Models
{
    public class RegistroVendas
    {
        public int ID { get; set; }
        public DateTime Data { get; set; }
        public double  Quantia { get; set; }
        public StatusVenda Status { get; set; }
        public Vendedor Vendedor { get; set; }

        public RegistroVendas()
        { 
        
        }

        public RegistroVendas(int iD, DateTime data, double quantia, StatusVenda status, Vendedor vendedor)
        {
            ID = iD;
            Data = data;
            Quantia = quantia;
            Status = status;
            Vendedor = vendedor;
        }
    }
}
