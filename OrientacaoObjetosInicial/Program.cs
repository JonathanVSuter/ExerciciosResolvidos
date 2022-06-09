using System;

namespace OrientacaoObjetosInicial
{
    //public class MotoristaCaminhao : Motorista 
    //{        
    //    public string LicensaCargaPerigosa;
    //    public DateTime Idade() 
    //    {
    //        return new DateTime((DataNascimento - DateTime.Now).Ticks);
    //    }
    //}
    public class Motorista 
    {
        public static void MostrarTexto() 
        {
            Console.WriteLine("Texto");
        }
        //Quando escrever o nome de um campo, usar o primeiro nome com letra maiúscula
        //e as demais palavras dentro da declaração com letra maiúscula também.
        private Guid CodigoMotorista { get; set; }
        public string Nome { get; set; }
        protected DateTime DataNascimento { get; set; }
        //private string _cpf;
        //public string Cpf 
        //{ 
        //    get 
        //    {
        //        return Convert.ToUInt64(_cpf).ToString(@"000\.000\.000\-00");
        //    }
        //    set 
        //    {
        //        _cpf = value;
        //    }
        //}        
        public string Cpf {get;set;}
        public string Rg { get; set; }
        public string Cnh { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public double Salario { get; set; }
        public string CategoriaCnh { get; set; }
        private bool _Ativo { get; set; }
        //construtor com dados completos;
        public Motorista(Guid codigoMotorista, string nome, DateTime dataNascimento,
            string cpf, string cnh, string telefone, string endereco, double salario, string categoriaCnh, string rg)
        {
            this.CodigoMotorista = codigoMotorista;
            this.Nome = nome;
            this.DataNascimento = dataNascimento;
            this.Cpf = Convert.ToUInt64(cpf).ToString(@"000\.000\.000\-00");            
            this.Cnh = cnh;
            this.Telefone = telefone;
            this.Endereco = endereco;
            this.Salario = salario;
            this.CategoriaCnh = categoriaCnh;
            this.Rg = rg;
        }        

        //construtor vazio;
        public Motorista() { }
        //construtor sem o campo identificador preenchido;
        public Motorista(string nome, DateTime dataNascimento,
            string cpf, string cnh, string telefone, string endereco, double salario, string categoriaCnh, string rg)
        {
            this.Nome = nome;
            this.DataNascimento = dataNascimento;
            this.Cpf = cpf;
            this.Cnh = cnh;
            this.Telefone = telefone;
            this.Endereco = endereco;
            this.Salario = salario;
            this.CategoriaCnh = categoriaCnh;
            this.Rg = rg;
        }
        public void Demite(bool estado) 
        {
            this._Ativo = estado;
        }
        public string IdMot() 
        {
            return this.PegarIdMotorista();
        }
        public string PegarIdMotorista()
        {
            return this.CodigoMotorista.ToString();
        }         
    }
    class Program
    {
        static void Main(string[] args)
        {
            Motorista motorista = new Motorista(Guid.NewGuid(), "Jonathan", new DateTime(1996, 06, 19),"09479806959","000000000", "47997443418","Rua A", 2500,"AB", "5989267");            
            Motorista motorista1 = new Motorista();
            //método estático
            Motorista.MostrarTexto();
            motorista.Demite(false);
            //Motorista motorista1 = new Motorista();
            //MotoristaCaminhao motoristaCaminhao = new MotoristaCaminhao();
            Console.WriteLine("Nome:" + motorista.Nome);
            Console.WriteLine("CPF:" + motorista.Cpf);
            Console.WriteLine("Endereço:" + motorista.Endereco);
            Console.WriteLine("Telefone:" + motorista.Telefone);
            Console.WriteLine("Salario:" + motorista.Salario);
            motorista.Cpf = "00000000000";

        }
    }
}
