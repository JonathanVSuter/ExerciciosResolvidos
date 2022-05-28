using System;

namespace MMC
{
    class Program
    {
        static void Main(string[] args)
        {            
            CalcularMmc();
        }
        static void MostrarValoresEmTela(int n1, int n2, int n3) 
        {
            Console.Write(n1);
            Console.Write("----");
            Console.Write(n2);
            Console.Write("----");
            Console.Write(n3);
            Console.WriteLine("");
        }           
        static int SeValorDivisivelPoriEfetuaDivisao(int n,int i) 
        {
            if (n % i == 0)
                n /= i;
            return n;
        }
        static bool ValidaSeHaAlgumValorDivisivelPori(int n1, int n2, int n3, int i) 
        {
            return n1 % i == 0 || n2 % i == 0 || n3 % i == 0;
        }
        static bool VerificaValoresMaiorQueUm(int n1, int n2, int n3) 
        {            
            return n1 > 1 || n2 > 1 || n3 > 1;
        }
        //static void CalcularMmc(int n1, int n2, int n3)
        static void CalcularMmc()
        {

            int i = 2;
            int n1sobra = Convert.ToInt32(Console.ReadLine());
            int n2sobra = Convert.ToInt32(Console.ReadLine());
            int n3sobra = Convert.ToInt32(Console.ReadLine());
            int acumulador = 1;

            //1o passo: enquanto houver algum valor maior que 1, haverá iteração;
            while (VerificaValoresMaiorQueUm(n1sobra, n2sobra, n3sobra))
            {
                //2o passo: caso algum dos valores seja divisível por i,
                //verifica qual deles é divisível e efetua a operação;
                if (ValidaSeHaAlgumValorDivisivelPori(n1sobra, n2sobra, n3sobra, i))
                {
                    //3o passo: descobre qual dos valores é divisível e efetua a operação
                    //sobreescrevendo o valor na variável (para manter os valores nas divisões sucessivas);

                    n1sobra = SeValorDivisivelPoriEfetuaDivisao(n1sobra, i);
                    n2sobra = SeValorDivisivelPoriEfetuaDivisao(n2sobra, i);
                    n3sobra = SeValorDivisivelPoriEfetuaDivisao(n3sobra, i);
                    
                    //4o passo: o acumulador é o responsável por guardar
                    //o resultado parcial da multiplicação dos fatores primos;
                    acumulador *= i;

                    //opcional: mostrando os valores das variáveis  
                    MostrarValoresEmTela(n1sobra, n2sobra, n3sobra);
                }
                else
                {
                    i++;
                }
                Console.WriteLine("Acumulador " + acumulador);
                Console.WriteLine("Valor de i " + i);
            }
            Console.WriteLine("Resultado final: " + acumulador);
        }
    }
}
