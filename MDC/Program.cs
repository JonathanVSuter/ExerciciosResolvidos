using System;

namespace MDC
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[3];
            Console.WriteLine("Insira 3 valores pra calcular o MDC");
            numeros[0] = Convert.ToInt32(Console.ReadLine());
            numeros[1] = Convert.ToInt32(Console.ReadLine());
            numeros[2] = Convert.ToInt32(Console.ReadLine());         
          
            int menor = CalcularMenorValor(numeros);

            CalcularMdc(numeros, menor);
        }
        static void CalcularMdc(int[] valores, int menor) 
        {
            int maxDivComum = 0;

            for (int i = 1; i <= menor; i++)
            {
                if ((valores[0] % i == 0) && (valores[1] % i == 0) && (valores[2] % i == 0))
                {
                    maxDivComum = i;
                }
            }
            Console.WriteLine("Maior divisor comum: " + maxDivComum);
        }
        static int CalcularMenorValor(int[] valores) 
        {
            int menor;
            if (valores[0] < valores[1] && valores[0] < valores[2])
                menor = valores[0];
            else if (valores[1] < valores[0] && valores[1] < valores[2])
                menor = valores[1];
            else
                menor = valores[2];

            return menor;
        }
    }
}
