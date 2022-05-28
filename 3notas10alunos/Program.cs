using System;

namespace _3notas10alunos
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] notas1 = new double[10];
            double[] notas2 = new double[10];
            double[] notas3 = new double[10];
                       
            Random random = new Random();
            
            //1o passo: pegando as notas dos alunos
            for (int i=0; i<10; i++) 
            {
                Console.WriteLine($"Insira as notas do {i}o aluno");
                notas1[i] = random.NextDouble() * 10;
                notas2[i] = random.NextDouble() * 10;
                notas3[i] = random.NextDouble() * 10;
            }

            
            //2o passo: encontrar a menor e a maior nota de cada aluno
            //2.1o encontrar a menor nota de cada aluno:
            int[] menoresNotas = EncontrarMenorNotaIndividual(notas1, notas2, notas3);          
            double menorNotaGeral = EncontrarMenorNotaGeral(notas1, notas2, notas3);
            Console.WriteLine("A menor nota geral é "+ menorNotaGeral);
            double maiorNotaGeral = EncontrarMaiorNotaGeral(notas1, notas2, notas3);
            Console.WriteLine("A maior nota geral é " + maiorNotaGeral);
            CalcularMedias(notas1, notas2, notas3, menoresNotas);

        }
        static void CalcularMedias(double[] n1, double[] n2, double[] n3, int[] menoresNotas) 
        {
            double[] medias = new double[n1.Length];

            for (int i = 0; i < n1.Length; i++) 
            {
                if (menoresNotas[i] == 1)
                    medias[i] = (n2[i] + n3[i]) / 2;
                if(menoresNotas[i] == 2)
                    medias[i] = (n1[i] + n3[i]) / 2;
                if (menoresNotas[i] == 3)
                    medias[i] = (n2[i] + n2[i]) / 2;
            }
            for (int i=0; i< n1.Length; i++) 
            {
                Console.WriteLine($"A média do aluno {i} é {medias[i]}");
            }
        }
        static double EncontrarMaiorNotaGeral(double[] n1, double[] n2, double[] n3) 
        {
            double maiorNota = 0;

            for (int i = 0; i < n1.Length; i++)
            {
                //2.2.1 comparar nota a nota qual a menor em todos os alunos;
                if (n1[i] > n2[i] && n1[i] > n3[i] && n1[i] > maiorNota)
                    maiorNota = n1[i];
                else if (n2[i] > n1[i] && n2[i] > n3[i] && n2[i] > maiorNota)
                    maiorNota = n2[i];
                else if (n3[i] > n1[i] && n3[i] > n2[i] && n3[i] > maiorNota)
                    maiorNota = n3[i];                
            }            
            return maiorNota;
        }
        static double EncontrarMenorNotaGeral(double[] n1, double[] n2, double[] n3) 
        {
            double menorNota = 10;

            for (int i = 0; i < n1.Length; i++)
            {
                //2.2.1 comparar nota a nota qual a menor em todos os alunos;
                if (n1[i] < n2[i] && n1[i] < n3[i] && n1[i] < menorNota)
                    menorNota = n1[i];
                else if (n2[i] < n1[i] && n2[i] < n3[i] && n2[i] < menorNota)
                    menorNota = n2[i];
                else if (n3[i] < n1[i] && n3[i] < n2[i] && n3[i] < menorNota)
                    menorNota = n3[i];               
            }
            //
            return menorNota;
        }
        static int[] EncontrarMenorNotaIndividual(double[] n1, double[] n2, double[] n3) 
        {
            //2.1o encontrar a menor nota de cada aluno;
            int[] referenciaNotaMenorNota = new int[n1.Length];

            //2.2 percorrer todos os arrays e encontrar
            //a posição da menor nota de cada;

            for (int i=0; i< referenciaNotaMenorNota.Length; i++) 
            {
                //2.2.1 comparar nota a nota qual a menor;
                if (n1[i] < n2[i] && n1[i] < n3[i])
                    referenciaNotaMenorNota[i] = 1;
                else if (n2[i] < n1[i] && n2[i] < n3[i])
                    referenciaNotaMenorNota[i] = 2;
                else
                    referenciaNotaMenorNota[i] = 3;
            }

            //2.3 retorna um array com as posições horizontais das menores notas;

            return referenciaNotaMenorNota;
        }

    }
}
