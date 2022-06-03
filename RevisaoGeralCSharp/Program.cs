using System;

namespace RevisaoGeralCSharp
{
    class Program
    {
        //Exercício 1
        /*1- Faça um programa que receba dois números que o usuário digitou, 
        faça a soma e mostre na tela*/
        //static void Main(string[] args)
        //{
        //    double n1;
        //    double n2;

        //    Console.WriteLine("Insira o valor para n1");
        //    n1 = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("Insira o valor para n2");
        //    n2 = Convert.ToDouble(Console.ReadLine());
        //    double res = n1 + n2;
        //    Console.WriteLine("O Resultado da soma é" + res);
        //}
        /*Exercício 2: Escreva um programa que receba 2 valores e mostre 
         * o maior entre eles;
         */

        //static void Main(string[] args)
        //{
        //    double n1;
        //    double n2;

        //    Console.WriteLine("Insira o valor para n1");
        //    n1 = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("Insira o valor para n2");
        //    n2 = Convert.ToDouble(Console.ReadLine());

        //    if (n1>n2) 
        //    {
        //        Console.WriteLine("O maior valor é n1");
        //    }
        //    else if (n2>n1) 
        //    {
        //        Console.WriteLine("O maior valor é n2");
        //    }
        //    else 
        //    {
        //        Console.WriteLine("Os valores são iguais");
        //    }           
        //}
        //static void Main(string[] args)
        //{
        //    int anoDeNascimento;            

        //    Console.WriteLine("Insira o seu ano de nascimento:");
        //    anoDeNascimento = Convert.ToInt32(Console.ReadLine());

        //    //isso:
        //    //int res = DateTime.Now.Year - anoDeNascimento;
        //    //é o mesmo que isso:
        //    int res = 2022 - anoDeNascimento;

        //    Console.WriteLine("Sua idade é"+ res);            
        //}

        //Exercício 4
        //static void Main(string[] args)
        //{
        //    double x;

        //    x = 8 / 2;

        //    Console.WriteLine("O resultado é "+x);
        //}
        //static void Main(string[] args) 
        //{
        //    double a = 10;
        //    double[] vetorPreenchido = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        //    double[] vetora = new double[10];
        //    double[] vetorb = new double[6];

        //    vetora[2] = 1;

        //    //percorrer dois ou mais vetores ao mesmo tempo,
        //    //preenchendo os valores nas mesmas posições
        //    for (int i= 0; i < vetora.Length; i++) 
        //    {
        //        vetora[i] = i * vetorPreenchido[i];
        //        vetorb[i] = 2 + vetorPreenchido[i];
        //    }

        //    //AdicionarValorDouble(a);
        //    //AdicionarValor(ref a);

        //    //PreencherVetor(vetor);
        //}
        //static void AdicionarValor(ref double a)
        //{
        //    a++;
        //    Console.WriteLine("Valor de com ref");
        //}
        //static void AdicionarValorDouble(double a) 
        //{
        //    a++;
        //    Console.WriteLine("Valor de sem ref");
        //}
        //static void PreencherVetor(double[] v) 
        //{
        //1o Faça um programa que receba 5 números e mostre o 
        //dobro dos valores informados;
        //    //ver o vetor de trás para frente:
        //    //for (int i = 9; i >= 0; i--)
        //    for (int j =0; j < v.Length; j++) 
        //    {
        //        v[j] = 1;
        //    }

        //    //preenchendo usando while
        //    int i = 0;
        //    while (i < v.Length) 
        //    {
        //        v[i] = 1;
        //        i++;
        //    }            

        //    i = 0;
        //    //preenchendo usando do-while
        //    do
        //    {
        //        v[i] = 1;
        //        i++;
        //    }
        //    while (i < v.Length);
        //}
        //static void Main(string[] args)
        //{
        //    int[] vetor = new int[5];
        //    Random random = new Random();           

        //    //preencher
        //    for(int i = 0; i<vetor.Length; i++) 
        //    {
        //        vetor[i] = random.Next(0, 10);
        //        //Console.WriteLine("O dobro é: " + vetor[i] * 2);
        //    }
        //    //mostrar
        //    for (int i = 0; i < vetor.Length; i++)
        //    {
        //        Console.WriteLine("O dobro é: " + vetor[i] * 2);
        //    }
        //}
        //static void Main(string[] args) 
        //{
        //    //2o Faça um programa que receba 7 valores e 
        //    //atribua em outro vetor;
        //    int[] vetor = new int[7];
        //    int[] vetor1 = new int[7];
        //    Random random = new Random();

        //    //preencher o primeiro vetor
        //    for (int i = 0; i < vetor.Length; i++)
        //    {
        //        vetor[i] = random.Next(0, 10);                
        //    }

        //    //passar os valores para o segundo
        //    for (int i = 0; i < vetor.Length; i++)
        //    {
        //        vetor1[i] = vetor[i];
        //    }

        //    for (int i = 0; i < vetor.Length; i++)
        //    {
        //        Console.WriteLine(vetor1[i]);
        //    }
        //}

        //static void Main(string[] args) 
        //{
        //    //3o Faça um programa que receba 5 valores e
        //    //multiplique cada posição do vetor pelo seu índice;

        //    int[] vetor = new int[5];            
        //    Random random = new Random();

        //    for (int i = 0; i < vetor.Length; i++)
        //    {
        //        vetor[i] = random.Next(0, 10);
        //        Console.WriteLine(vetor[i] * i);
        //    }

        //}
        //static void Main(string[] args) 
        //{
        //    //4o Faça um programa que receba um texto e a 
        //    //partir deste texto, jogue os valores em um novo vetor e
        //    //mostre cada posição linha a linha;

        //    string texto = Console.ReadLine();
        //    char[] chars = new char[texto.Length];

        //    //peguei os valores da cadeia de texto (letra por letra)
        //    //e joga na posição correspondente no vetor de char
        //    for(int i = 0; i < chars.Length; i++)
        //    {
        //        chars[i] = texto[i];
        //    }
        //    //mostra os valores linha a linha
        //    for (int i = 0; i < chars.Length; i++) 
        //    {
        //        Console.WriteLine(chars[i]);
        //    }


        //}

        static void Main(string[] args) 
        {
            int[,] matriz = new int[5,5];
            Random random = new Random();
            //percorrer
            //primeiro for são as linhas
            for (int i = 0; i < matriz.GetLength(0); i++) 
            {
                //segundo são as colunas;
                for (int j =0; j< matriz.GetLength(1); j++) 
                {
                    matriz[i,j] = random.Next(0,10);
                }
            }

            for (int i = 0; i < matriz.GetLength(0); i++)
            {                
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = random.Next(0, 10);
                    Console.Write("-"+ matriz[i, j]+"-");
                }
                Console.WriteLine();
            }
        }
    }


}

