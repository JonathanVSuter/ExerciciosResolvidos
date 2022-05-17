using System;

namespace MostrarDivisoresAteN
{
    class Program
    {
        static void Main(string[] args)
        {
            int entrada;
            int[] retorno;
            //1o passo: pedir entrada pra o usuário:
            Console.WriteLine("Insira um valor:");
            entrada = Convert.ToInt32(Console.ReadLine());
            //2o passo: calcular os divisores (via função);
            retorno = Divisores(entrada);
            //6o passo: passar para uma função que mostre os valores em tela
            MostrarValores(retorno);
        }
        static void MostrarValores(int[] valores) 
        {            
            Console.WriteLine("Mostrando divisores:");
            for (int i=0; i<valores.Length; i++ ) 
            {
                /*só mostrará os valores nas posições em que foram setados os 
                divisores*/
                if(valores[i] > 0) 
                {
                    Console.WriteLine(valores[i]);
                }                
            }
        }
        static int[] Divisores(int num) 
        {
            //3o passo: cria a variável de retorno
            int[] divisores = new int[num + 1];
            
            for (int i=1; i <divisores.Length; i++) 
            {
                //4o passo: percorre o vetor e insere no array os divisores
                if(num % i == 0) 
                {
                    divisores[i] = i;
                }
            }
            //5o passo: retorna o array com os divisores para a função "Main"
            return divisores;
        }
    }
}
