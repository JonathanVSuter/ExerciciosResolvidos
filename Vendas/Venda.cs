using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vendas
{
    public class Venda
    {
        public double ValorTotal 
        { 
            get 
            {
                double total = 0;
                if (Produtos != null && Produtos.Any())
                {
                    foreach (Produto p in Produtos)
                    {
                        total += p.Preco;
                    }
                }
                return total;
            }
        }
        public Cliente Cliente { get; set; }
        public Vendedor Vendedor { get; set; }
        public List<Produto> Produtos { get; set; }
        public bool Finalizada { get; set; }
        public Venda(Cliente cliente, Vendedor vendedor) 
        {
            this.Vendedor = vendedor;            
            this.Cliente = cliente;
        }
        public Venda(Cliente cliente, Vendedor vendedor, List<Produto> produtos)
        {
            this.Produtos = produtos;
            this.Vendedor = vendedor;
            this.Cliente = cliente;
        }
        public Venda() { }        
    }
}
