using System;

namespace Ex1RevisaoFuncoes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, res;
            Console.WriteLine("Insira o valor para n1");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira o valor para n2");
            n2 = Convert.ToInt32(Console.ReadLine());
            res = Soma(n1, n2);
            Console.WriteLine("A soma é: " + res);
        }
        static int Soma(int numero1, int numero2) 
        {
            return numero1 + numero2;
        }
    }
}
