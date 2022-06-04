using System;

namespace Ex4RevisaoFuncoes
{
    class Program
    {
        static void Main(string[] args)
        {
            //4- Faça um programa que receba uma string em uma função e retorne
            //um array de char desse texto;
            string texto = Console.ReadLine();
            char[] res = ConverterEmArrayChar(texto);
        }
        static char[] ConverterEmArrayChar(string texto) 
        {
            char[] vetor = new char[texto.Length];

            for (int i =0; i < vetor.Length; i++) 
            {
                vetor[i] = texto[i];
            }
            return vetor;
        }
    }
}
