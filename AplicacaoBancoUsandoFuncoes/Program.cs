using System;

namespace AplicacaoBancoUsandoFuncoes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numeroContas = {"a", "b", "c", "d","e" };
            double[] saldoContas = new double[] {1000, 2000, 3000, 4000, 5000};

            //pegando as contas dos usuários e os saldos das mesmas;
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Insira o código da conta " + i);
            //    numeroContas[i] = Console.ReadLine();
            //    Console.WriteLine("Insira o saldo da conta " + i);
            //    saldoContas[i] = Convert.ToDouble(Console.ReadLine());
            //}

            Console.WriteLine("Insira a opcao que deseja:");
            Console.WriteLine("1-Sacar");
            Console.WriteLine("2-Depositar");
            Console.WriteLine("3-Transferir");
            Console.WriteLine("0-Sair");
            int opcao = Convert.ToInt32(Console.ReadLine());
            while (opcao != (int)Operacao.Sair) 
            {
                if (opcao == (int)Operacao.Sacar) 
                {                    
                    Console.WriteLine("Por favor, informe a conta para saque:");
                    string contaSaque = Console.ReadLine();
                    Console.WriteLine("Informe o valor para saque");
                    double valorSaque = Convert.ToDouble(Console.ReadLine());

                    saldoContas = Sacar(saldoContas, numeroContas, contaSaque, valorSaque);
                }
                else if (opcao == (int)Operacao.Depositar) 
                {
                    Console.WriteLine("Por favor, informe a conta para saque:");
                    string contaSaque = Console.ReadLine();
                    Console.WriteLine("Informe o valor para saque");
                    double valorDeposito = Convert.ToDouble(Console.ReadLine());

                    saldoContas = Depositar(saldoContas, numeroContas, contaSaque, valorDeposito);                
                }
                else if(opcao == (int)Operacao.Transferir)
                {
                    Console.WriteLine("Por favor, informe a conta origem:");
                    string contaOrigem = Console.ReadLine();

                    Console.WriteLine("Por favor, informe a conta destino:");
                    string contaDestino = Console.ReadLine();

                    Console.WriteLine("Informe o valor para transferência:");
                    double valorTransf = Convert.ToDouble(Console.ReadLine());

                    saldoContas = Transferir(saldoContas, numeroContas, contaOrigem, contaDestino, valorTransf);
                }
                Console.WriteLine("Insira a opcao que deseja:");
                Console.WriteLine("1-Sacar");
                Console.WriteLine("2-Depositar");
                Console.WriteLine("3-Transferir");
                Console.WriteLine("0-Sair");
                opcao = Convert.ToInt32(Console.ReadLine());
            }
        }
        //static void Sacar(double[] saldoContas_p, string[] numeroContas_p, string conta, double valorSaque)
        //{
        //    {
        //        //encontrar a conta;
        //        for (int i = 0; i < numeroContas_p.Length; i++)
        //        {
        //            //verificar se é a mesma conta;
        //            if (numeroContas_p[i] == conta)
        //            {
        //                //quando encontra a conta, mostra uma mensagem na tela;
        //                Console.WriteLine("Conta encontrada.");
        //                //verifica se a conta possui valor suficiente para o saldo;
        //                if (saldoContas_p[i] >= valorSaque)
        //                {
        //                    //caso haja saldo, efetua o saque.
        //                    saldoContas_p[i] = saldoContas_p[i] - valorSaque;
        //                    Console.WriteLine("Saque efetuado.");
        //                }
        //            }
        //        }
        //    }
        //}
        ////função usando retorno;
        static double[] Sacar(double[] saldoContas_p, string[] numeroContas_p, string conta, double valorSaque)
        {
            //encontrar a conta;
            for (int i = 0; i < numeroContas_p.Length; i++)
            {
                //verificar se é a mesma conta;
                if (numeroContas_p[i] == conta)
                {
                    //quando encontra a conta, mostra uma mensagem na tela;
                    Console.WriteLine("Conta encontrada.");
                    //verifica se a conta possui valor suficiente para o saldo;
                    if (saldoContas_p[i] >= valorSaque)
                    {
                        //caso haja saldo, efetua o saque.
                        saldoContas_p[i] = saldoContas_p[i] - valorSaque;
                        Console.WriteLine("Saque efetuado.");
                    }
                    else 
                    {
                        Console.WriteLine("Você está sem saldo.");
                    }
                }
            }

            return saldoContas_p;
        }
        static double[] Depositar(double[] saldoContas_p, string[] numeroContas_p, string conta, double valorDeposito) 
        {
            for (int i = 0; i < numeroContas_p.Length; i++)
            {
                //verificar se é a mesma conta;
                if (numeroContas_p[i] == conta) 
                {
                    Console.WriteLine("Conta encontrada");
                    saldoContas_p[i] = saldoContas_p[i] + valorDeposito;
                    Console.WriteLine("Deposito efetuado.");
                }
            }
            return saldoContas_p;
        }
        static double[] Transferir(double[] saldoContas_p, string[] numeroContas_p, string contaOrigem, string contaDestino, double valorTransf) 
        {
            for (int i=0; i <saldoContas_p.Length; i++) 
            {
                if(numeroContas_p[i] == contaOrigem) 
                {
                    Console.WriteLine("Conta de origem encontrada");
                    if(saldoContas_p[i] >= valorTransf) 
                    {
                        for (int j = 0; j < saldoContas_p.Length; j++)
                        {
                            if(numeroContas_p[j] == contaDestino) 
                            {
                                saldoContas_p[j] = saldoContas_p[j] + valorTransf;
                                saldoContas_p[i] -= valorTransf;
                            }
                        }
                    }
                    else 
                    {
                        Console.WriteLine("Conta sem saldo suficiente.");
                    }
                }
            }
            return saldoContas_p;
        }
        enum Operacao
        {
            Sair,
            Sacar,
            Depositar,
            Transferir
        }
    }
}
