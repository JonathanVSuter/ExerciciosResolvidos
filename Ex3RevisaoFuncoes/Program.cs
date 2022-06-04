using System;

namespace Ex3RevisaoFuncoes
{
    class Program
    {
        static void Main(string[] args)
        {
            //3- Faça um programa que receba dois valores, coloque em uma função e
            //retorne o menor deles;
            Random random = new Random();
            int a, b;
            a = random.Next(0,10);
            b = random.Next(0, 10);
            int res = RetornarMenor(a, b);
            Console.WriteLine("O menor é:"+res);
        }
        static int RetornarMenor(int n1, int n2) 
        {
            if (n1 < n2)
                return n1;
            else
                return n2;
        }
    }
}
