using System;
using System.Collections.Generic;
using System.Text;

namespace Vendas
{
    public class Venda
    {
        public double ValorTotal { get; set; }
        public Cliente Cliente { get; set; }
        public Vendedor Vendedor { get; set; }
        public Venda(double valorTotal, Cliente cliente, Vendedor vendedor) 
        {
            this.Vendedor = vendedor;
            this.ValorTotal = valorTotal;
            this.Cliente = cliente;
        }
    }
}
