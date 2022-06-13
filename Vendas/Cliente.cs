using System;
using System.Collections.Generic;
using System.Text;

namespace Vendas
{
    public class Cliente
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }
        public Cliente(string nome, string cpf, string endereco) 
        {
            this.Nome = nome;
            this.Cpf = cpf;
            this.Endereco = endereco;
        }
    }
}
