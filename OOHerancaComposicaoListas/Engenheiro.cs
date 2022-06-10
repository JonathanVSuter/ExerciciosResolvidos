namespace OOHerancaComposicaoListas
{
    public class Engenheiro : Funcionario
    {
        public string Crea { get; set; }
        public string AreaAtuacao { get; set; }
        public Engenheiro() 
        {
        }
        public Engenheiro(string crea, string areaAtuacao, double salario, string rg):base() 
        {            
            this.Crea = crea;
            this.AreaAtuacao = areaAtuacao;
            this.Salario = salario;            
        }
    }
}
