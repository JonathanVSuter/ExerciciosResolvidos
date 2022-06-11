using System;

namespace Vendas
{
    class Program
    {
        static void Main(string[] args)
        {
            Vendedor vendedor = new Vendedor("Zé ", "2456412");
            Vendedor vendedor1 = new Vendedor("Zé ", "2456412");

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
