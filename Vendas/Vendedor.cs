using System;
using System.Collections.Generic;
using System.Text;

namespace Vendas
{
    public class Vendedor
    {
        public int Codigo { get; set;}
        public string Nome { get; set; }
        public string CodigoCracha { get; set; }
        public Vendedor(int codigo,string nome, string codigoCracha) 
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.CodigoCracha = codigoCracha;
        }
        public Vendedor() { }
    }
}
