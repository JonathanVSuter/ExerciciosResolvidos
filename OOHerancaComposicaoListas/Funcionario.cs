namespace OOHerancaComposicaoListas
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Departamento { get; set; }
        public double Salario { get; set; }
        public string DataAdmissao { get; set; }
        private string Rg { get; set; }        
        public bool Ativo { get; set; }

        public void Bonifica(double valor) 
        {
            this.Salario += valor;
        }
        public void Demitir(bool estado) 
        {
            this.Ativo = estado;
        }    
        public Funcionario() { }
        public Funcionario(string rg) 
        {
            this.Rg = rg;
        }
        public Funcionario(double salario, string rg) 
        {
            this.Salario = salario;
            this.Rg = rg;
        }        
    }
}
