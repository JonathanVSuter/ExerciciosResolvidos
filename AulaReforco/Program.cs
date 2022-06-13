using System;

namespace AulaReforco
{
    class Program
    {        
        static void Main(string[] args)
        {
            int quantidade = 0;
            Console.WriteLine("Informe a quantidade de valores que deseja inserir");
            quantidade = Convert.ToInt32(Console.ReadLine());
            int[] vetor = new int[quantidade];
            for(int i=0; i< quantidade; i++) 
            {
                vetor[i] = PedirValores();
            }
        }
        static int PedirValores() 
        {
            Console.WriteLine("Informe um valor:");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
