/*1) Modele um funcionário. Ele deve ter o nome do funcionário,
o departamento onde trabalha, seu salário (double), a data de 
entrada de admissão (string),seu RG(string) e um valor booleano 
que indique se o funcionário ainda está ativo na empresa ou se
 já foi mandado embora.Você deve criar alguns métodos de acordo 
com sua necessidade. Além deles, crie um método "Bonifica" que 
aumenta o salario do funcionário de acordo com o parâmetro 
passado como argumento. Crie, também, um método "Demite",
que não recebe parâmetro algum, só modifica o valor booleano 
indicando que o funcionário não trabalha mais aqui. */


using System;

namespace OOFuncionario
{    
    public class Contato 
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
    }
    public class Pessoa  
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public Contato[] Contato { get; set; }
        public string Cpf { get; set; }
        public Pessoa(string nome, string telefone, string cpf) 
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.Cpf = cpf;
        }
        public Pessoa() { }
    }
    //public class Departamento 
    //{
    //    public string Nome { get; set; }
    //    public string CentroDeCusto { get; set; }
    //    public string Ramal { get; set; }
    //    public Funcionario Gerente { get; set; }
    //}
    public class Funcao 
    {
        public string Descricao { get; set; }
    }
    public class Funcionario 
    {
        public Funcao Funcao { get; set; }
        public string Nome 
        { 
            get; 
            set; 
        }
        public string Departamento 
        { 
            get; 
            set; 
        }
        public double Salario 
        { 
            get; 
            set; 
        }
        public string DataAdmissao 
        { 
            get; 
            set; 
        }
        public string Rg 
        { 
            get; 
            set; 
        }
        public bool Ativo 
        { 
            get; 
            set; 
        }
        public void Bonifica(double valor) 
        {
            this.Salario += valor;
        }
        public void Demite(bool estado) 
        {
            this.Ativo = estado;
        }
        public Funcionario(string nome, string departamento, double salario, string dataAdmissao, string rg, bool ativo) 
        {
            this.Nome = nome;
            this.Departamento = departamento;
            this.Salario = salario;
            this.DataAdmissao = dataAdmissao;
            this.Rg = rg;
            this.Ativo = ativo;
        }
        public Funcionario() 
        {
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Pessoa pessoa = new Pessoa();
            //pessoa.Contato = new Contato[10];

            //for (int i = 0; i < pessoa.Contato.Length; i++)
            //{
            //    pessoa.Contato[i] = new Contato();
            //    pessoa.Contato[i].Nome = "Teste";
            //    pessoa.Contato[i].Telefone = "47997443418";
            //}

            //foreach (Contato contato in pessoa.Contato)
            //{                
            //    contato.Nome = "Texto";
            //    contato.Telefone = "47997443418";
            //}

            //Exercício 1 - implementação e uso da classe "Funcionario".

            //pegando valores do usuário:
            Funcionario funcionario = new Funcionario(Console.ReadLine(), Console.ReadLine(),
                                                      Convert.ToDouble(Console.ReadLine()),
                                                      Console.ReadLine(), Console.ReadLine(), true);
            //funcionario;
            Console.WriteLine("Nome: " + funcionario.Nome);
            Console.WriteLine("Ativo: " + funcionario.Ativo);
            Console.WriteLine("Data de Admissao: " + funcionario.DataAdmissao);
            Console.WriteLine("Departamento: " + funcionario.Departamento);
            Console.WriteLine("Rg: " + funcionario.Rg);
            Console.WriteLine("Salario: " + funcionario.Salario);

            //com valores estáticos:
            Funcionario funcionario1 = new Funcionario("Jonathan", "Gerência Tecnologia da Informação",
                                                      2500.0,"15/07/2021", "5989267", true);
            //funcionario1;
            Console.WriteLine("Nome: " + funcionario1.Nome);
            Console.WriteLine("Ativo: " + funcionario1.Ativo);
            Console.WriteLine("Data de Admissao: " + funcionario1.DataAdmissao);
            Console.WriteLine("Departamento: " + funcionario1.Departamento);
            Console.WriteLine("Rg: " + funcionario1.Rg);
            Console.WriteLine("Salario: " + funcionario1.Salario);

            //Passando os valores depois da inicialização (usando get e set)
            Funcionario funcionario2 = new Funcionario();

            //funcionario2;
            Console.WriteLine("Nome: " + funcionario2.Nome);
            Console.WriteLine("Ativo: " + funcionario2.Ativo);
            Console.WriteLine("Data de Admissao: " + funcionario2.DataAdmissao);
            Console.WriteLine("Departamento: " + funcionario2.Departamento);
            Console.WriteLine("Rg: " + funcionario2.Rg);
            Console.WriteLine("Salario: " + funcionario2.Salario);

            funcionario2.Ativo = true;
            funcionario2.DataAdmissao = "15/07/2021";
            funcionario2.Departamento = "Gerência Tecnologia da Informação";
            funcionario2.Nome = "Jonathan";
            funcionario2.Rg = "5989267";
            funcionario2.Salario = 2500.0;

            funcionario2.Demite(false);
            funcionario2.Demite(true);
            funcionario2.Bonifica(1500);

            Console.WriteLine("Nome: " + funcionario2.Nome);
            Console.WriteLine("Ativo: " + funcionario2.Ativo);
            Console.WriteLine("Data de Admissao: " + funcionario2.DataAdmissao);
            Console.WriteLine("Departamento: " + funcionario2.Departamento);
            Console.WriteLine("Rg: " + funcionario2.Rg);
            Console.WriteLine("Salario: " + funcionario2.Salario);
        }
    }
}
