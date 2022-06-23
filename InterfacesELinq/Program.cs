using System;
using System.Collections.Generic;
using System.Linq;

namespace InterfacesELinq
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Hello World!");

            Repositor repositor = new Repositor() { CodigoDeCracha = "00001", Nome = "José", Local = "Loja" };
            Gerente gerente = new Gerente() { Nome = "João", AreaGestao = "Fiscal", CodigoDeCracha = "00000" };

            MostrarDadosFuncionario(repositor);
            MostrarDadosFuncionario(gerente);

            //CustomCollection1 items = new CustomCollection1();
            //items.Add(new Item() 
            //{ 
            //    Descricao = "Teste" 
            //});
            //items.Add(new Item()
            //{
            //    Descricao = "Teste1"
            //});

            //CustomCollection2 items1 = new CustomCollection2();
            //items1.Add(new Item()
            //{
            //    Descricao = "Teste3"
            //});

            //RecebeLista(items);
            //RecebeLista(items1);

        }
        public static void RecebeLista(ICollection<Item> collection) 
        {
            collection.Add(new Item() { Descricao = "teste" });
        }
        public static void MostrarDadosFuncionario(IFuncionario funcionario) 
        {
            Console.WriteLine("Nome"+funcionario.Nome);
            Console.WriteLine("Cracha"+funcionario.CodigoDeCracha);
            Console.WriteLine("Bonificação"+funcionario.Bonificacao);
        }
    }
}
