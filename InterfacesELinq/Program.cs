using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;


/*
 *  Marca
    Descrição
    ValorEmReal
    ValorMoedaOrigem
    País de origem
 * 
 */
namespace InterfacesELinq
{
    public interface IProduto 
    {
        int Id { get; set; }
        string Marca { get; set; }
        string Descricao { get; set; }
        double Valor { get; set; }
        double ValorMoedaOrigem { get;}
        string PaisOrigem { get; set; }        
    }
    public class Macarrao : IProduto
    {
        public int Id { get; set; }
        public string Marca { get; set ; }
        public string Descricao { get ; set ; }
        public double Valor { get ; set ; }
        public double ValorMoedaOrigem 
        { 
            get 
            {
                return Valor / 5.51;
            }
        }
        public string PaisOrigem { get ; set ; }
        public override string ToString()
        {
            return $"Descrição: {Descricao}, Marca: {Marca}, Valor: {Valor}, Valor de Origem: {ValorMoedaOrigem}";
        }
    }
    public class Leite : IProduto
    {
        public int Id { get; set; }
        public string Marca { get ; set ; }
        public string Descricao { get ; set ; }
        public double Valor { get ; set ; }
        public double ValorMoedaOrigem
        {
            get
            {
                return Valor / 14.91;
            }
        }
        public string PaisOrigem { get ; set ; }
        public override string ToString()
        {
            return $"Descrição: {Descricao}, Marca: {Marca}, Valor: {Valor}, Valor de Origem: {ValorMoedaOrigem}";
        }
    }    
    public class Carne : IProduto
    {       
        public int Id { get; set; }
        public virtual string Marca { get ; set ; }
        public string Descricao { get ; set ; }
        public double Valor { get ; set ; }
        public double ValorMoedaOrigem
        {
            get
            {
                return Valor;
            }
        }
        public string PaisOrigem { get ; set ; }
        public override string ToString()
        {            
            return $"Descrição: {Descricao}, Marca: {Marca}, Valor: {Valor}, Valor de Origem: {ValorMoedaOrigem}";
        }
    }
    class Program
    {
        static IProduto EncontrarProduto(IList<IProduto> produtos, int id) 
        {            
            IProduto produto = null;
            foreach (IProduto p in produtos) 
            {
                if(p.Id == id) 
                {
                    produto = p;
                }
            }
            return produto;
        }
        static IList<IProduto> BuscarProdutos(IList<IProduto> produtos, string descricao)
        {
            IList<IProduto> produtosEncontrados = new List<IProduto>();

            foreach (IProduto p in produtos)
            {
                if (p.ToString().Contains(descricao))
                {
                    if(p.GetType() == typeof(Macarrao)) 
                    {
                        produtosEncontrados.Add(new Macarrao()
                        {
                            Descricao = p.Descricao,
                            Id = p.Id,
                            Marca = p.Marca,
                            PaisOrigem = p.PaisOrigem,
                            Valor = p.Valor
                        });
                    }
                }
            }
            return produtosEncontrados;
        }
        static IList<IProduto> BuscarProdutosLinq(IList<IProduto> produtos, string descricao)
        {
            //consulta usando linq:
            var produtosEncontrados = produtos.Where(x => x.ToString().Contains(descricao)).ToList();
            return produtosEncontrados;            
        }
        static void Main(string[] args)
        {
            List<IProduto> produtos = new List<IProduto>();
            produtos.Add(new Leite() 
            {
                Descricao = "Da vaca",
                Marca = "Tirol",
                PaisOrigem = "Índia",
                Valor = 5.25
            });
            produtos.Add(new Carne()
            {
                Descricao = "Mignon",
                Marca = "Friboi",
                PaisOrigem = "Brasil",
                Valor = 95
            });
            produtos.Add(new Macarrao()
            {
                Descricao = "Penne",
                Marca = "Bologna",
                PaisOrigem = "Índia",
                Valor = 7.25
            });
            produtos.Add(new Macarrao()
            {
                Descricao = "Penne",
                Marca = "Bologna",
                PaisOrigem = "Índia",
                Valor = 7.25
            });
            produtos.Add(new Macarrao()
            {
                Descricao = "Penne",
                Marca = "Bologna",
                PaisOrigem = "Índia",
                Valor = 7.25
            });

            IList<IProduto> produtosEncontrados = BuscarProdutosLinq(produtos, "P");

            //foreach (IProduto produto in produtos)
            //{
            //    Console.WriteLine(produto.ToString());                                
            //}
            ////List<IFuncionario> funcionarios = new List<IFuncionario>();
            //List<IFuncionario> funcionarios = new List<IFuncionario>() 
            //{
            //    new Repositor()
            //    {
            //        CodigoDeCracha = "",
            //        Local = "",
            //        Nome = "",
            //        Salario = 2500
            //    },
            //    new Repositor()
            //    {
            //        CodigoDeCracha = "",
            //        Local = "",
            //        Nome = "",
            //        Salario = 2500
            //    },
            //    new Repositor()
            //    {
            //        CodigoDeCracha = "",
            //        Local = "",
            //        Nome = "",
            //        Salario = 2500
            //    },
            //    new Repositor()
            //    {
            //        CodigoDeCracha = "",
            //        Local = "",
            //        Nome = "",
            //        Salario = 2500
            //    },
            //    new Gerente()
            //    {
            //        CodigoDeCracha = "",
            //        AreaGestao = "",
            //        Nome = "",
            //        Salario = 2500                    
            //    }
            //};            

            //Console.WriteLine("Hello World!");

            //Repositor repositor = new Repositor() { CodigoDeCracha = "00001", Nome = "José", Local = "Loja" };
            //Gerente gerente = new Gerente() { Nome = "João", AreaGestao = "Fiscal", CodigoDeCracha = "00000" };
            //funcionarios.Add(repositor);
            //funcionarios.Add(gerente);
            ////funcionarios.ForEach(e => 
            ////{
            ////    Console.WriteLine("Nome:" + e.Nome);
            ////    Console.WriteLine("Código de crachá:" + e.CodigoDeCracha); ;
            ////    Console.WriteLine("Bonificação: " + e.Bonificacao);
            ////});

            //foreach (IFuncionario funcionario in funcionarios) 
            //{
            //    Console.WriteLine("Nome:" + funcionario.Nome);
            //    Console.WriteLine("Código de crachá:" + funcionario.CodigoDeCracha); ;
            //    Console.WriteLine("Bonificação: "+funcionario.Bonificacao);
            //}
            ////foreach (IFuncionario funcionario in funcionarios) 
            ////{
            ////    //if(funcionario is Gerente) 
            ////    if (funcionario.GetType() == typeof(Gerente))
            ////    {
            ////        Gerente g = (Gerente)funcionario;
            ////        Console.WriteLine("Nome:" + funcionario.Nome);
            ////        Console.WriteLine("Código de crachá:" + funcionario.CodigoDeCracha); ;
            ////        Console.WriteLine("Bonificação: " + funcionario.Bonificacao);
            ////        Console.WriteLine("Área gestão" + g.AreaGestao);
            ////    }
            ////}

            //MostrarDadosFuncionario(repositor);
            //MostrarDadosFuncionario(gerente);

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
