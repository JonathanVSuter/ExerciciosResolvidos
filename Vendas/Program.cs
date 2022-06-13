using System;
using System.Collections.Generic;

namespace Vendas
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public string Marca { get; set; }
        public double Preco { get; set; }
        public Produto(int codigo, string descricao, string marca, double preco) 
        {
            this.Codigo = codigo;
            this.Descricao = descricao;
            this.Marca = marca;
            this.Preco = preco;
        }
        public override string ToString()
        {
            return $"{this.Codigo} {this.Marca} {this.Descricao} {this.Preco}";
        }
    }
    public class Carrinho
    {
        public List<Produto> Produtos { get; set; } = new List<Produto>();      
    }
    class Program
    {       
        static void ListarProdutos(List<Produto> produtos) 
        {
            foreach (Produto produto in produtos) 
            {
                Console.WriteLine($"Descrição: {produto.Descricao}");
                Console.WriteLine($"Marca: {produto.Marca}");
                Console.WriteLine($"Preço: {produto.Preco}");
            }
        }
        static Produto EncontrarProduto(List<Produto> produtos, int codigo) 
        {
            Produto produto = null;
            for (int i = 0; i < produtos.Count; i++)
            {
                if (produtos[i].Codigo == codigo)
                {
                    produto = produtos[i];
                }
            }
            return produto;
            //Encontrar usando um cadeia de texto com override do método "ToString()" na classe "Produtos";
            //for (int i = 0; i < produtos.Count; i++)
            //{
            //    if (produtos[i].ToString().Contains(descricaoProduto))
            //    {
            //        carrinho.Produtos.Add(produtos[i]);
            //    }
            //}
        }
        static void Main(string[] args)
        {
            List<Vendedor> vendedores = new List<Vendedor>();
            List<Cliente> clientes = new List<Cliente>();
            List<Venda> vendas = new List<Venda>();
            Carrinho carrinho = new Carrinho();
            List<Produto> produtos = new List<Produto>();
            produtos.Add(new Produto(0,"Picanha a vácuo", "Bestbeef", 120));
            produtos.Add(new Produto(1,"Maminha a vácuo", "Bestbeef", 75));
            produtos.Add(new Produto(2,"Contra-filé a vácuo", "Bestbeef", 60));
            produtos.Add(new Produto(3,"Fraldinha a vácuo", "Bestbeef", 65));
            produtos.Add(new Produto(4,"Entrecot a vácuo", "Bestbeef", 80));            
            //mostrar os produtos registrados
            ListarProdutos(produtos);
            Console.WriteLine("Insira a descrição do produto");
            int codigoProduto = Convert.ToInt32(Console.ReadLine());
            //usa a função "EncontrarProduto" para buscar um elemento baseado no campo "código" do produto.
            Produto produtoEncontrado = EncontrarProduto(produtos, codigoProduto);





            //recuperar um produto da lista:







            //dentro da condição da compra;




            //lista de produtos;
            //Carrinho de compras;
            //ações


            Vendedor vendedor = new Vendedor("Zé ", "2456412");
            Vendedor vendedor1 = new Vendedor("Zé ", "2456412");
            vendedores.Add(vendedor);
            vendedores.Add(vendedor1);

            Cliente cliente = new Cliente("Dirceu", "000000000", "Rua das Dores");
            Cliente cliente1 = new Cliente("Dirceu", "000000000", "Rua das Dores");

            Venda v1 = new Venda(2000, cliente, vendedor);
            Venda v2 = new Venda(2000, cliente1, vendedor1);

            Console.WriteLine("Cliente na venda 1 "+v1.Cliente.Nome) ;
            Console.WriteLine("Cliente na venda 2 "+v2.Cliente.Nome);

            Console.WriteLine("Vendedor na venda 1 "+v1.Vendedor.Nome);
            Console.WriteLine("Vendedor na venda 1 "+v2.Vendedor.Nome);

            Console.WriteLine("Crachá do vendedor na venda 1 " + v1.Vendedor.CodigoCracha);
            Console.WriteLine("Crachá do vendedor na venda 2 " + v2.Vendedor.CodigoCracha);

        }
    }
}
