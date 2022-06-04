using System;

namespace Ex2RevisaoFuncoes
{
    class Program
    {//2- Faça um programa que receba um vetor de 10
     //posições e mostre a média dos valores;
        static void Main(string[] args)
        {
            Random random = new Random();
            double[] vetor = new double[10];
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = random.NextDouble()*10;                
            }
            MostrarMedia(vetor);
        }
        static void MostrarMedia(double[] valores) 
        {
            double somatorio=0;
            for (int i = 0; i < valores.Length; i++)
            {
                somatorio += valores[i]; 
            }
            double media = somatorio / valores.Length;
            Console.WriteLine("A média geral é: " + media);
        }
    }
}
