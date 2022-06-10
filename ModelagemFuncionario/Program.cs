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

namespace ModelagemFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Bonifica(100);
            Funcionario funcionario1 = new Funcionario();
            funcionario1.Demitir(false);
            Funcionario funcionario2 = new Funcionario();
            funcionario2.Salario = 2000;
            funcionario2.Bonifica(500);
            Funcionario funcionario3 = new Funcionario();
            funcionario3.Nome = "Teste";
            funcionario3.Departamento = "Dpto Teste";
            //cadastro...
            Console.WriteLine("Funcionário ativo?");
            funcionario.Ativo = Convert.ToBoolean(Console.ReadLine());

        }
    }
}
