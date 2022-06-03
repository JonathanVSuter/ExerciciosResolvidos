using System;

namespace RevisaoFuncoes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //int b = Teste(10);
            //string valor = ConverterParaTexto(b);
            //int[] valores = PreencherVetor(50);
            //PreencherVetor(valores);
            //int[] vetor2 = PreencherVetor(10, out int retorno);
            IniciarJogo();
        }
        //Funções
        //static + tipo de retorno(se se retorno, void) + nome da função + (parâmetros entre parênteses){}
        //exemplo:
        static int Teste(double a)
        {
            a *= 10;//é o mesmo que: a = a * 10;
            return Convert.ToInt32(a);
        }
        //retornando texto
        static string ConverterParaTexto(int valor)
        {
            return valor.ToString();
        }
        //Formas de preencher o vetor usando funções:
        //Implementação 1: passando o tamanho do vetor e retonando
        //ele preenchido;
        static int[] PreencherVetor(int tamanho)
        {
            int[] vetor = new int[tamanho];
            Random random = new Random();
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = random.Next(0, 10);
            }
            return vetor;
        }
        //Implementação 2: usando referência para preencher o vetor, sem retorno.
        static void PreencherVetor(int[] vetor)
        {
            Random random = new Random();
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = random.Next(0, 10);
            }
        }
        //Implementação 3 com mais de um retorno
        static int[] PreencherVetor(int tamanho, out int ultimoValor)
        {
            int[] vetor = new int[tamanho];
            int valor = 0;
            Random random = new Random();
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = random.Next(0, 10);
                valor = vetor[i];
            }
            ultimoValor = valor;
            return vetor;
        }
        static void IniciarJogo()
        {
            Console.WriteLine("Digite o alcance máximo para adivinhar");
            int max = Convert.ToInt32(Console.ReadLine());
            FazerIteracoes(max);
        }
        static void FazerIteracoes(int valorMaximo) 
        {
            Random random = new Random();
            int valorAleatorio = random.Next(0, valorMaximo);
            Console.WriteLine("Jogo iniciado.");
            Console.WriteLine("Insira um valor para adivinhar");
            int entradaUsuario = Convert.ToInt32(Console.ReadLine());
            int tentativas = 1;
            while (entradaUsuario != valorAleatorio) 
            {
                tentativas++;
                if (entradaUsuario > valorAleatorio) 
                {
                    Console.WriteLine("Valor aleatório é menor");
                }
                else 
                {
                    Console.WriteLine("Valor aleatório é maior");
                }
                Console.WriteLine("Errrrrrou. Você pega quanto na rosca?");
                Console.WriteLine("Insira um valor para adivinhar");
                entradaUsuario = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Você adivinhou.");
            Console.WriteLine("Você aguenta quanto na rosca? Acho que:"+tentativas);
        }
        
            
        
    }
}
