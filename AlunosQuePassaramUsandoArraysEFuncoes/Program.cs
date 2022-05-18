using System;

namespace AlunosQuePassaramUsandoArraysEFuncoes
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] notas = new double[10];
            Random random = new Random();
            //1o passo: pedir as entradas ao usuário
            for (int i =0; i<notas.Length; i++) 
            {
                Console.WriteLine("Por favor, insira a nota do aluno: "+i);
                //notas[i] = Convert.ToDouble(Console.ReadLine());
                notas[i] = random.NextDouble() * 10;    
            }

            //5o passo: guardar o retorno da função
            bool[] resultado = AprovadosReprovados(notas);

            //6o passo (opcional): mostrar os alunos que estão aprovados:
            for (int i = 0; i < notas.Length; i++) 
            {
                if (resultado[i]) 
                {
                    Console.WriteLine("Aluno "+i+" aprovado");
                }
            }
        }
        static bool[] AprovadosReprovados(double[] notas) 
        {
            /*2o passo: percorrer o array e verificaar os alunos que têm
              nota maior que 7
             */
            bool[] aprovadosReprovados = new bool[notas.Length];
            for (int i = 0; i < notas.Length; i++)
            {
                if(notas[i] > 7) 
                {
                    /*3o passo: caso a nota seja maior que 7, atribuo "True" na posição
                      respectiva do array.
                    */
                    aprovadosReprovados[i] = true;
                }
            }
            //4o passo: retornar o array preenchido com os estados dos alunos
            return aprovadosReprovados;            
        }
    }
}
