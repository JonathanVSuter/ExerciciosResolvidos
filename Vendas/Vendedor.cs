using System;
using System.Collections.Generic;
using System.Text;

namespace Vendas
{
    public class Vendedor
    {
        public string Nome { get; set; }
        public string CodigoCracha { get; set; }
        public Vendedor(string nome, string codigoCracha) 
        {
            this.Nome = nome;
            this.CodigoCracha = codigoCracha;
        }
    }
}
