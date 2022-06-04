using System;

namespace Ex5RevisaoFuncoes
{
    class Program
    {
        //Faça um programa que dê opções ao usuário em uma calculadora e 
        //        ele possa fazer as seguintes operações:
        //    Soma;
        //	Subtração;
        //	Divisão;
        //	Multiplicação;
        //OBS: mostre todos os valores em tela.
        enum Operacoes 
        {
            Sair,
            Soma,
            Subtracao,
            Divisao,
            Multiplicao
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 0 para sair do programa.");
            Console.WriteLine("Digite 1 para Soma.");
            Console.WriteLine("Digite 2 para Subtracao.");
            Console.WriteLine("Digite 3 para Divisao.");
            Console.WriteLine("Digite 4 Multiplicacao.");
            Operacoes opcao = (Operacoes)Convert.ToInt32(Console.ReadLine());
            double res;
            double a;
            double b;
            while (opcao != Operacoes.Sair) 
            {                
                switch (opcao)
                {                    
                    case Operacoes.Soma:
                        Console.WriteLine("Informe o primeiro valor:");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe o segundo valor:");
                        b = Convert.ToDouble(Console.ReadLine());
                        res = Soma(a, b);
                        Console.WriteLine("A soma é:"+res);
                        break;
                    case Operacoes.Subtracao:
                        Console.WriteLine("Informe o primeiro valor:");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe o segundo valor:");
                        b = Convert.ToDouble(Console.ReadLine());
                        res = Subtracao(a, b);
                        Console.WriteLine("A Subtracao é:"+res);
                        break;
                    case Operacoes.Divisao:
                        Console.WriteLine("Informe o primeiro valor:");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe o segundo valor:");
                        b = Convert.ToDouble(Console.ReadLine());
                        res = Divisao(a, b);
                        Console.WriteLine("A Divisao é:"+res);
                        break;
                    case Operacoes.Multiplicao:
                        Console.WriteLine("Informe o primeiro valor:");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe o segundo valor:");
                        b = Convert.ToDouble(Console.ReadLine());
                        res = Multiplicacao(a, b);
                        Console.WriteLine("A Multiplicacao é:" + res);
                        break;
                }

                Console.WriteLine("Digite 0 para sair do programa.");
                Console.WriteLine("Digite 1 para Soma.");
                Console.WriteLine("Digite 2 para Subtracao.");
                Console.WriteLine("Digite 3 para Divisao.");
                Console.WriteLine("Digite 4 Multiplicacao.");
                opcao = Convert.ToInt32(Console.ReadLine());
            }
        }
        static double Soma(double a, double b) 
        {
            return a + b;
        }
        static double Subtracao(double a, double b)
        {
            return a - b;
        }
        static double Divisao(double a, double b)
        {
            return a / b;
        }
        static double Multiplicacao(double a, double b)
        {
            return a * b;
        }

    }
}
