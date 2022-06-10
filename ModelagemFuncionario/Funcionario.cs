namespace ModelagemFuncionario
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Departamento { get; set; }
        public double Salario { get; set; }
        public string DataAdmissao { get; set; }
        public string Rg { get; set; }
        public bool Ativo { get; set; }

        public void Bonifica(double valor) 
        {
            this.Salario += valor;
        }
        public void Demitir(bool estado) 
        {
            this.Ativo = estado;
        }
    }
}
